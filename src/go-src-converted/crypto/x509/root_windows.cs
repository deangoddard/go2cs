// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package x509 -- go2cs converted at 2022 March 06 22:19:52 UTC
// import "crypto/x509" ==> using x509 = go.crypto.x509_package
// Original source: C:\Program Files\Go\src\crypto\x509\root_windows.go
using errors = go.errors_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;

namespace go.crypto;

public static partial class x509_package {

    // Creates a new *syscall.CertContext representing the leaf certificate in an in-memory
    // certificate store containing itself and all of the intermediate certificates specified
    // in the opts.Intermediates CertPool.
    //
    // A pointer to the in-memory store is available in the returned CertContext's Store field.
    // The store is automatically freed when the CertContext is freed using
    // syscall.CertFreeCertificateContext.
private static (ptr<syscall.CertContext>, error) createStoreContext(ptr<Certificate> _addr_leaf, ptr<VerifyOptions> _addr_opts) => func((defer, _, _) => {
    ptr<syscall.CertContext> _p0 = default!;
    error _p0 = default!;
    ref Certificate leaf = ref _addr_leaf.val;
    ref VerifyOptions opts = ref _addr_opts.val;

    ptr<syscall.CertContext> storeCtx;

    var (leafCtx, err) = syscall.CertCreateCertificateContext(syscall.X509_ASN_ENCODING | syscall.PKCS_7_ASN_ENCODING, _addr_leaf.Raw[0], uint32(len(leaf.Raw)));
    if (err != null) {
        return (_addr_null!, error.As(err)!);
    }
    defer(syscall.CertFreeCertificateContext(leafCtx));

    var (handle, err) = syscall.CertOpenStore(syscall.CERT_STORE_PROV_MEMORY, 0, 0, syscall.CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG, 0);
    if (err != null) {
        return (_addr_null!, error.As(err)!);
    }
    defer(syscall.CertCloseStore(handle, 0));

    err = syscall.CertAddCertificateContextToStore(handle, leafCtx, syscall.CERT_STORE_ADD_ALWAYS, _addr_storeCtx);
    if (err != null) {
        return (_addr_null!, error.As(err)!);
    }
    if (opts.Intermediates != null) {
        for (nint i = 0; i < opts.Intermediates.len(); i++) {
            var (intermediate, err) = opts.Intermediates.cert(i);
            if (err != null) {
                return (_addr_null!, error.As(err)!);
            }
            var (ctx, err) = syscall.CertCreateCertificateContext(syscall.X509_ASN_ENCODING | syscall.PKCS_7_ASN_ENCODING, _addr_intermediate.Raw[0], uint32(len(intermediate.Raw)));
            if (err != null) {
                return (_addr_null!, error.As(err)!);
            }
            err = syscall.CertAddCertificateContextToStore(handle, ctx, syscall.CERT_STORE_ADD_ALWAYS, null);
            syscall.CertFreeCertificateContext(ctx);
            if (err != null) {
                return (_addr_null!, error.As(err)!);
            }
        }

    }
    return (_addr_storeCtx!, error.As(null!)!);

});

// extractSimpleChain extracts the final certificate chain from a CertSimpleChain.
private static (slice<ptr<Certificate>>, error) extractSimpleChain(ptr<ptr<syscall.CertSimpleChain>> _addr_simpleChain, nint count) {
    slice<ptr<Certificate>> chain = default;
    error err = default!;
    ref ptr<syscall.CertSimpleChain> simpleChain = ref _addr_simpleChain.val;

    if (simpleChain == null || count == 0) {
        return (null, error.As(errors.New("x509: invalid simple chain"))!);
    }
    ptr<array<ptr<syscall.CertSimpleChain>>> simpleChains = new ptr<ptr<array<ptr<syscall.CertSimpleChain>>>>(@unsafe.Pointer(simpleChain)).slice(-1, count, count);
    var lastChain = simpleChains[count - 1];
    ptr<array<ptr<syscall.CertChainElement>>> elements = new ptr<ptr<array<ptr<syscall.CertChainElement>>>>(@unsafe.Pointer(lastChain.Elements)).slice(-1, lastChain.NumElements, lastChain.NumElements);
    for (nint i = 0; i < int(lastChain.NumElements); i++) { 
        // Copy the buf, since ParseCertificate does not create its own copy.
        var cert = elements[i].CertContext;
        ptr<array<byte>> encodedCert = new ptr<ptr<array<byte>>>(@unsafe.Pointer(cert.EncodedCert)).slice(-1, cert.Length, cert.Length);
        var buf = make_slice<byte>(cert.Length);
        copy(buf, encodedCert);
        var (parsedCert, err) = ParseCertificate(buf);
        if (err != null) {
            return (null, error.As(err)!);
        }
        chain = append(chain, parsedCert);

    }

    return (chain, error.As(null!)!);

}

// checkChainTrustStatus checks the trust status of the certificate chain, translating
// any errors it finds into Go errors in the process.
private static error checkChainTrustStatus(ptr<Certificate> _addr_c, ptr<syscall.CertChainContext> _addr_chainCtx) {
    ref Certificate c = ref _addr_c.val;
    ref syscall.CertChainContext chainCtx = ref _addr_chainCtx.val;

    if (chainCtx.TrustStatus.ErrorStatus != syscall.CERT_TRUST_NO_ERROR) {
        var status = chainCtx.TrustStatus.ErrorStatus;

        if (status == syscall.CERT_TRUST_IS_NOT_TIME_VALID) 
            return error.As(new CertificateInvalidError(c,Expired,""))!;
        else if (status == syscall.CERT_TRUST_IS_NOT_VALID_FOR_USAGE) 
            return error.As(new CertificateInvalidError(c,IncompatibleUsage,""))!; 
            // TODO(filippo): surface more error statuses.
        else 
            return error.As(new UnknownAuthorityError(c,nil,nil))!;
        
    }
    return error.As(null!)!;

}

// checkChainSSLServerPolicy checks that the certificate chain in chainCtx is valid for
// use as a certificate chain for a SSL/TLS server.
private static error checkChainSSLServerPolicy(ptr<Certificate> _addr_c, ptr<syscall.CertChainContext> _addr_chainCtx, ptr<VerifyOptions> _addr_opts) {
    ref Certificate c = ref _addr_c.val;
    ref syscall.CertChainContext chainCtx = ref _addr_chainCtx.val;
    ref VerifyOptions opts = ref _addr_opts.val;

    var (servernamep, err) = syscall.UTF16PtrFromString(opts.DNSName);
    if (err != null) {
        return error.As(err)!;
    }
    ptr<syscall.SSLExtraCertChainPolicyPara> sslPara = addr(new syscall.SSLExtraCertChainPolicyPara(AuthType:syscall.AUTHTYPE_SERVER,ServerName:servernamep,));
    sslPara.Size = uint32(@unsafe.Sizeof(sslPara.val));

    ptr<syscall.CertChainPolicyPara> para = addr(new syscall.CertChainPolicyPara(ExtraPolicyPara:(syscall.Pointer)(unsafe.Pointer(sslPara)),));
    para.Size = uint32(@unsafe.Sizeof(para.val));

    ref syscall.CertChainPolicyStatus status = ref heap(new syscall.CertChainPolicyStatus(), out ptr<syscall.CertChainPolicyStatus> _addr_status);
    err = syscall.CertVerifyCertificateChainPolicy(syscall.CERT_CHAIN_POLICY_SSL, chainCtx, para, _addr_status);
    if (err != null) {
        return error.As(err)!;
    }
    if (status.Error != 0) {

        if (status.Error == syscall.CERT_E_EXPIRED) 
            return error.As(new CertificateInvalidError(c,Expired,""))!;
        else if (status.Error == syscall.CERT_E_CN_NO_MATCH) 
            return error.As(new HostnameError(c,opts.DNSName))!;
        else if (status.Error == syscall.CERT_E_UNTRUSTEDROOT) 
            return error.As(new UnknownAuthorityError(c,nil,nil))!;
        else 
            return error.As(new UnknownAuthorityError(c,nil,nil))!;
        
    }
    return error.As(null!)!;

}

// windowsExtKeyUsageOIDs are the C NUL-terminated string representations of the
// OIDs for use with the Windows API.
private static var windowsExtKeyUsageOIDs = make_map<ExtKeyUsage, slice<byte>>(len(extKeyUsageOIDs));

private static void init() {
    foreach (var (_, eku) in extKeyUsageOIDs) {
        windowsExtKeyUsageOIDs[eku.extKeyUsage] = (slice<byte>)eku.oid.String() + "\x00";
    }
}

private static (slice<ptr<Certificate>>, error) verifyChain(ptr<Certificate> _addr_c, ptr<syscall.CertChainContext> _addr_chainCtx, ptr<VerifyOptions> _addr_opts) {
    slice<ptr<Certificate>> chain = default;
    error err = default!;
    ref Certificate c = ref _addr_c.val;
    ref syscall.CertChainContext chainCtx = ref _addr_chainCtx.val;
    ref VerifyOptions opts = ref _addr_opts.val;

    err = checkChainTrustStatus(_addr_c, _addr_chainCtx);
    if (err != null) {
        return (null, error.As(err)!);
    }
    if (opts != null && len(opts.DNSName) > 0) {
        err = checkChainSSLServerPolicy(_addr_c, _addr_chainCtx, _addr_opts);
        if (err != null) {
            return (null, error.As(err)!);
        }
    }
    chain, err = extractSimpleChain(_addr_chainCtx.Chains, int(chainCtx.ChainCount));
    if (err != null) {
        return (null, error.As(err)!);
    }
    if (len(chain) == 0) {
        return (null, error.As(errors.New("x509: internal error: system verifier returned an empty chain"))!);
    }
    foreach (var (i, parent) in chain[(int)1..]) {
        if (parent.PublicKeyAlgorithm != ECDSA) {
            continue;
        }
        {
            var err = parent.CheckSignature(chain[i].SignatureAlgorithm, chain[i].RawTBSCertificate, chain[i].Signature);

            if (err != null) {
                return (null, error.As(err)!);
            }

        }

    }    return (chain, error.As(null!)!);

}

// systemVerify is like Verify, except that it uses CryptoAPI calls
// to build certificate chains and verify them.
private static (slice<slice<ptr<Certificate>>>, error) systemVerify(this ptr<Certificate> _addr_c, ptr<VerifyOptions> _addr_opts) => func((defer, _, _) => {
    slice<slice<ptr<Certificate>>> chains = default;
    error err = default!;
    ref Certificate c = ref _addr_c.val;
    ref VerifyOptions opts = ref _addr_opts.val;

    var (storeCtx, err) = createStoreContext(_addr_c, _addr_opts);
    if (err != null) {
        return (null, error.As(err)!);
    }
    defer(syscall.CertFreeCertificateContext(storeCtx));

    ptr<object> para = @new<syscall.CertChainPara>();
    para.Size = uint32(@unsafe.Sizeof(para.val));

    var keyUsages = opts.KeyUsages;
    if (len(keyUsages) == 0) {
        keyUsages = new slice<ExtKeyUsage>(new ExtKeyUsage[] { ExtKeyUsageServerAuth });
    }
    var oids = make_slice<ptr<byte>>(0, len(keyUsages));
    foreach (var (_, eku) in keyUsages) {
        if (eku == ExtKeyUsageAny) {
            oids = null;
            break;
        }
        {
            var (oid, ok) = windowsExtKeyUsageOIDs[eku];

            if (ok) {
                oids = append(oids, _addr_oid[0]);
            } 
            // Like the standard verifier, accept SGC EKUs as equivalent to ServerAuth.

        } 
        // Like the standard verifier, accept SGC EKUs as equivalent to ServerAuth.
        if (eku == ExtKeyUsageServerAuth) {
            oids = append(oids, _addr_syscall.OID_SERVER_GATED_CRYPTO[0]);
            oids = append(oids, _addr_syscall.OID_SGC_NETSCAPE[0]);
        }
    }    if (oids != null) {
        para.RequestedUsage.Type = syscall.USAGE_MATCH_TYPE_OR;
        para.RequestedUsage.Usage.Length = uint32(len(oids));
        para.RequestedUsage.Usage.UsageIdentifiers = _addr_oids[0];
    }
    else
 {
        para.RequestedUsage.Type = syscall.USAGE_MATCH_TYPE_AND;
        para.RequestedUsage.Usage.Length = 0;
        para.RequestedUsage.Usage.UsageIdentifiers = null;
    }
    ptr<syscall.Filetime> verifyTime;
    if (opts != null && !opts.CurrentTime.IsZero()) {
        ref var ft = ref heap(syscall.NsecToFiletime(opts.CurrentTime.UnixNano()), out ptr<var> _addr_ft);
        verifyTime = _addr_ft;
    }
    const nuint CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS = 0x00000080; 

    // CertGetCertificateChain will traverse Windows's root stores in an attempt to build a verified certificate chain
 

    // CertGetCertificateChain will traverse Windows's root stores in an attempt to build a verified certificate chain
    ptr<syscall.CertChainContext> topCtx;
    err = syscall.CertGetCertificateChain(syscall.Handle(0), storeCtx, verifyTime, storeCtx.Store, para, CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS, 0, _addr_topCtx);
    if (err != null) {
        return (null, error.As(err)!);
    }
    defer(syscall.CertFreeCertificateChain(topCtx));

    var (chain, topErr) = verifyChain(_addr_c, topCtx, _addr_opts);
    if (topErr == null) {
        chains = append(chains, chain);
    }
    {
        var lqCtxCount = topCtx.LowerQualityChainCount;

        if (lqCtxCount > 0) {
            ptr<array<ptr<syscall.CertChainContext>>> lqCtxs = new ptr<ptr<array<ptr<syscall.CertChainContext>>>>(@unsafe.Pointer(topCtx.LowerQualityChains)).slice(-1, lqCtxCount, lqCtxCount);

            foreach (var (_, ctx) in lqCtxs) {
                var (chain, err) = verifyChain(_addr_c, _addr_ctx, _addr_opts);
                if (err == null) {
                    chains = append(chains, chain);
                }
            }
        }
    }


    if (len(chains) == 0) { 
        // Return the error from the highest quality context.
        return (null, error.As(topErr)!);

    }
    return (chains, error.As(null!)!);

});

private static (ptr<CertPool>, error) loadSystemRoots() => func((defer, _, _) => {
    ptr<CertPool> _p0 = default!;
    error _p0 = default!;
 
    // TODO: restore this functionality on Windows. We tried to do
    // it in Go 1.8 but had to revert it. See Issue 18609.
    // Returning (nil, nil) was the old behavior, prior to CL 30578.
    // The if statement here avoids vet complaining about
    // unreachable code below.
    if (true) {
        return (_addr_null!, error.As(null!)!);
    }
    const nuint CRYPT_E_NOT_FOUND = 0x80092004;



    var (store, err) = syscall.CertOpenSystemStore(0, syscall.StringToUTF16Ptr("ROOT"));
    if (err != null) {
        return (_addr_null!, error.As(err)!);
    }
    defer(syscall.CertCloseStore(store, 0));

    var roots = NewCertPool();
    ptr<syscall.CertContext> cert;
    while (true) {
        cert, err = syscall.CertEnumCertificatesInStore(store, cert);
        if (err != null) {
            {
                syscall.Errno (errno, ok) = err._<syscall.Errno>();

                if (ok) {
                    if (errno == CRYPT_E_NOT_FOUND) {
                        break;
                    }
                }

            }

            return (_addr_null!, error.As(err)!);

        }
        if (cert == null) {
            break;
        }
        ptr<array<byte>> buf = new ptr<ptr<array<byte>>>(@unsafe.Pointer(cert.EncodedCert)).slice(-1, cert.Length, cert.Length);
        var buf2 = make_slice<byte>(cert.Length);
        copy(buf2, buf);
        {
            var (c, err) = ParseCertificate(buf2);

            if (err == null) {
                roots.AddCert(c);
            }

        }

    }
    return (_addr_roots!, error.As(null!)!);

});

} // end x509_package
