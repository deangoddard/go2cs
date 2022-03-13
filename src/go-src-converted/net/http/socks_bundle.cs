// Code generated by golang.org/x/tools/cmd/bundle. DO NOT EDIT.
//go:generate bundle -o socks_bundle.go -prefix socks golang.org/x/net/internal/socks

// Package socks provides a SOCKS version 5 client implementation.
//
// SOCKS protocol version 5 is defined in RFC 1928.
// Username/Password authentication for SOCKS version 5 is defined in
// RFC 1929.
//

// package http -- go2cs converted at 2022 March 13 05:37:35 UTC
// import "net/http" ==> using http = go.net.http_package
// Original source: C:\Program Files\Go\src\net\http\socks_bundle.go
namespace go.net;

using context = context_package;
using errors = errors_package;
using io = io_package;
using net = net_package;
using strconv = strconv_package;
using time = time_package;
using System;
using System.Threading;

public static partial class http_package {

private static time.Time socksnoDeadline = new time.Time();private static var socksaLongTimeAgo = time.Unix(1, 0);

private static (net.Addr, error) connect(this ptr<socksDialer> _addr_d, context.Context ctx, net.Conn c, @string address) => func((defer, _, _) => {
    net.Addr _ = default;
    error ctxErr = default!;
    ref socksDialer d = ref _addr_d.val;

    var (host, port, err) = sockssplitHostPort(address);
    if (err != null) {
        return (null, error.As(err)!);
    }
    {
        var (deadline, ok) = ctx.Deadline();

        if (ok && !deadline.IsZero()) {
            c.SetDeadline(deadline);
            defer(c.SetDeadline(socksnoDeadline));
        }
    }
    if (ctx != context.Background()) {
        var errCh = make_channel<error>(1);
        var done = make_channel<object>();
        defer(() => {
            close(done);
            if (ctxErr == null) {
                ctxErr = errCh.Receive();
            }
        }());
        go_(() => () => {
            c.SetDeadline(socksaLongTimeAgo);
            errCh.Send(ctx.Err());
            errCh.Send(null);
        }());
    }
    var b = make_slice<byte>(0, 6 + len(host)); // the size here is just an estimate
    b = append(b, socksVersion5);
    if (len(d.AuthMethods) == 0 || d.Authenticate == null) {
        b = append(b, 1, byte(socksAuthMethodNotRequired));
    }
    else
 {
        var ams = d.AuthMethods;
        if (len(ams) > 255) {
            return (null, error.As(errors.New("too many authentication methods"))!);
        }
        b = append(b, byte(len(ams)));
        {
            var am__prev1 = am;

            foreach (var (_, __am) in ams) {
                am = __am;
                b = append(b, byte(am));
            }

            am = am__prev1;
        }
    }
    _, ctxErr = c.Write(b);

    if (ctxErr != null) {
        return ;
    }
    _, ctxErr = io.ReadFull(c, b[..(int)2]);

    if (ctxErr != null) {
        return ;
    }
    if (b[0] != socksVersion5) {
        return (null, error.As(errors.New("unexpected protocol version " + strconv.Itoa(int(b[0]))))!);
    }
    var am = socksAuthMethod(b[1]);
    if (am == socksAuthMethodNoAcceptableMethods) {
        return (null, error.As(errors.New("no acceptable authentication methods"))!);
    }
    if (d.Authenticate != null) {
        ctxErr = d.Authenticate(ctx, c, am);

        if (ctxErr != null) {
            return ;
        }
    }
    b = b[..(int)0];
    b = append(b, socksVersion5, byte(d.cmd), 0);
    {
        var ip = net.ParseIP(host);

        if (ip != null) {
            {
                var ip4 = ip.To4();

                if (ip4 != null) {
                    b = append(b, socksAddrTypeIPv4);
                    b = append(b, ip4);
                }                {
                    var ip6 = ip.To16();


                    else if (ip6 != null) {
                        b = append(b, socksAddrTypeIPv6);
                        b = append(b, ip6);
                    }
                    else
 {
                        return (null, error.As(errors.New("unknown address type"))!);
                    }

                }

            }
        }
        else
 {
            if (len(host) > 255) {
                return (null, error.As(errors.New("FQDN too long"))!);
            }
            b = append(b, socksAddrTypeFQDN);
            b = append(b, byte(len(host)));
            b = append(b, host);
        }
    }
    b = append(b, byte(port >> 8), byte(port));
    _, ctxErr = c.Write(b);

    if (ctxErr != null) {
        return ;
    }
    _, ctxErr = io.ReadFull(c, b[..(int)4]);

    if (ctxErr != null) {
        return ;
    }
    if (b[0] != socksVersion5) {
        return (null, error.As(errors.New("unexpected protocol version " + strconv.Itoa(int(b[0]))))!);
    }
    {
        var cmdErr = socksReply(b[1]);

        if (cmdErr != socksStatusSucceeded) {
            return (null, error.As(errors.New("unknown error " + cmdErr.String()))!);
        }
    }
    if (b[2] != 0) {
        return (null, error.As(errors.New("non-zero reserved field"))!);
    }
    nint l = 2;
    ref socksAddr a = ref heap(out ptr<socksAddr> _addr_a);

    if (b[3] == socksAddrTypeIPv4) 
        l += net.IPv4len;
        a.IP = make(net.IP, net.IPv4len);
    else if (b[3] == socksAddrTypeIPv6) 
        l += net.IPv6len;
        a.IP = make(net.IP, net.IPv6len);
    else if (b[3] == socksAddrTypeFQDN) 
        {
            var (_, err) = io.ReadFull(c, b[..(int)1]);

            if (err != null) {
                return (null, error.As(err)!);
            }

        }
        l += int(b[0]);
    else 
        return (null, error.As(errors.New("unknown address type " + strconv.Itoa(int(b[3]))))!);
        if (cap(b) < l) {
        b = make_slice<byte>(l);
    }
    else
 {
        b = b[..(int)l];
    }
    _, ctxErr = io.ReadFull(c, b);

    if (ctxErr != null) {
        return ;
    }
    if (a.IP != null) {
        copy(a.IP, b);
    }
    else
 {
        a.Name = string(b[..(int)len(b) - 2]);
    }
    a.Port = int(b[len(b) - 2]) << 8 | int(b[len(b) - 1]);
    return (_addr_a, error.As(null!)!);
});

private static (@string, nint, error) sockssplitHostPort(@string address) {
    @string _p0 = default;
    nint _p0 = default;
    error _p0 = default!;

    var (host, port, err) = net.SplitHostPort(address);
    if (err != null) {
        return ("", 0, error.As(err)!);
    }
    var (portnum, err) = strconv.Atoi(port);
    if (err != null) {
        return ("", 0, error.As(err)!);
    }
    if (1 > portnum || portnum > 0xffff) {
        return ("", 0, error.As(errors.New("port number out of range " + port))!);
    }
    return (host, portnum, error.As(null!)!);
}

// A Command represents a SOCKS command.
private partial struct socksCommand { // : nint
}

private static @string String(this socksCommand cmd) {

    if (cmd == socksCmdConnect) 
        return "socks connect";
    else if (cmd == sockscmdBind) 
        return "socks bind";
    else 
        return "socks " + strconv.Itoa(int(cmd));
    }

// An AuthMethod represents a SOCKS authentication method.
private partial struct socksAuthMethod { // : nint
}

// A Reply represents a SOCKS command reply code.
private partial struct socksReply { // : nint
}

private static @string String(this socksReply code) {

    if (code == socksStatusSucceeded) 
        return "succeeded";
    else if (code == 0x01) 
        return "general SOCKS server failure";
    else if (code == 0x02) 
        return "connection not allowed by ruleset";
    else if (code == 0x03) 
        return "network unreachable";
    else if (code == 0x04) 
        return "host unreachable";
    else if (code == 0x05) 
        return "connection refused";
    else if (code == 0x06) 
        return "TTL expired";
    else if (code == 0x07) 
        return "command not supported";
    else if (code == 0x08) 
        return "address type not supported";
    else 
        return "unknown code: " + strconv.Itoa(int(code));
    }

// Wire protocol constants.
private static readonly nuint socksVersion5 = 0x05;

private static readonly nuint socksAddrTypeIPv4 = 0x01;
private static readonly nuint socksAddrTypeFQDN = 0x03;
private static readonly nuint socksAddrTypeIPv6 = 0x04;

private static readonly socksCommand socksCmdConnect = 0x01; // establishes an active-open forward proxy connection
private static readonly socksCommand sockscmdBind = 0x02; // establishes a passive-open forward proxy connection

private static readonly socksAuthMethod socksAuthMethodNotRequired = 0x00; // no authentication required
private static readonly socksAuthMethod socksAuthMethodUsernamePassword = 0x02; // use username/password
private static readonly socksAuthMethod socksAuthMethodNoAcceptableMethods = 0xff; // no acceptable authentication methods

private static readonly socksReply socksStatusSucceeded = 0x00;

// An Addr represents a SOCKS-specific address.
// Either Name or IP is used exclusively.
private partial struct socksAddr {
    public @string Name; // fully-qualified domain name
    public net.IP IP;
    public nint Port;
}

private static @string Network(this ptr<socksAddr> _addr_a) {
    ref socksAddr a = ref _addr_a.val;

    return "socks";
}

private static @string String(this ptr<socksAddr> _addr_a) {
    ref socksAddr a = ref _addr_a.val;

    if (a == null) {
        return "<nil>";
    }
    var port = strconv.Itoa(a.Port);
    if (a.IP == null) {
        return net.JoinHostPort(a.Name, port);
    }
    return net.JoinHostPort(a.IP.String(), port);
}

// A Conn represents a forward proxy connection.
private partial struct socksConn : net.Conn {
    public ref net.Conn Conn => ref Conn_val;
    public net.Addr boundAddr;
}

// BoundAddr returns the address assigned by the proxy server for
// connecting to the command target address from the proxy server.
private static net.Addr BoundAddr(this ptr<socksConn> _addr_c) {
    ref socksConn c = ref _addr_c.val;

    if (c == null) {
        return null;
    }
    return c.boundAddr;
}

// A Dialer holds SOCKS-specific options.
private partial struct socksDialer {
    public socksCommand cmd; // either CmdConnect or cmdBind
    public @string proxyNetwork; // network between a proxy server and a client
    public @string proxyAddress; // proxy server address

// ProxyDial specifies the optional dial function for
// establishing the transport connection.
    public Func<context.Context, @string, @string, (net.Conn, error)> ProxyDial; // AuthMethods specifies the list of request authentication
// methods.
// If empty, SOCKS client requests only AuthMethodNotRequired.
    public slice<socksAuthMethod> AuthMethods; // Authenticate specifies the optional authentication
// function. It must be non-nil when AuthMethods is not empty.
// It must return an error when the authentication is failed.
    public Func<context.Context, io.ReadWriter, socksAuthMethod, error> Authenticate;
}

// DialContext connects to the provided address on the provided
// network.
//
// The returned error value may be a net.OpError. When the Op field of
// net.OpError contains "socks", the Source field contains a proxy
// server address and the Addr field contains a command target
// address.
//
// See func Dial of the net package of standard library for a
// description of the network and address parameters.
private static (net.Conn, error) DialContext(this ptr<socksDialer> _addr_d, context.Context ctx, @string network, @string address) {
    net.Conn _p0 = default;
    error _p0 = default!;
    ref socksDialer d = ref _addr_d.val;

    {
        var err__prev1 = err;

        var err = d.validateTarget(network, address);

        if (err != null) {
            var (proxy, dst, _) = d.pathAddrs(address);
            return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
        }
        err = err__prev1;

    }
    if (ctx == null) {
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:errors.New("nil context")))!)!);
    }
    err = default!;
    net.Conn c = default;
    if (d.ProxyDial != null) {
        c, err = d.ProxyDial(ctx, d.proxyNetwork, d.proxyAddress);
    }
    else
 {
        net.Dialer dd = default;
        c, err = dd.DialContext(ctx, d.proxyNetwork, d.proxyAddress);
    }
    if (err != null) {
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
    }
    var (a, err) = d.connect(ctx, c, address);
    if (err != null) {
        c.Close();
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
    }
    return (addr(new socksConn(Conn:c,boundAddr:a)), error.As(null!)!);
}

// DialWithConn initiates a connection from SOCKS server to the target
// network and address using the connection c that is already
// connected to the SOCKS server.
//
// It returns the connection's local address assigned by the SOCKS
// server.
private static (net.Addr, error) DialWithConn(this ptr<socksDialer> _addr_d, context.Context ctx, net.Conn c, @string network, @string address) {
    net.Addr _p0 = default;
    error _p0 = default!;
    ref socksDialer d = ref _addr_d.val;

    {
        var err = d.validateTarget(network, address);

        if (err != null) {
            var (proxy, dst, _) = d.pathAddrs(address);
            return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
        }
    }
    if (ctx == null) {
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:errors.New("nil context")))!)!);
    }
    var (a, err) = d.connect(ctx, c, address);
    if (err != null) {
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
    }
    return (a, error.As(null!)!);
}

// Dial connects to the provided address on the provided network.
//
// Unlike DialContext, it returns a raw transport connection instead
// of a forward proxy connection.
//
// Deprecated: Use DialContext or DialWithConn instead.
private static (net.Conn, error) Dial(this ptr<socksDialer> _addr_d, @string network, @string address) {
    net.Conn _p0 = default;
    error _p0 = default!;
    ref socksDialer d = ref _addr_d.val;

    {
        var err__prev1 = err;

        var err = d.validateTarget(network, address);

        if (err != null) {
            var (proxy, dst, _) = d.pathAddrs(address);
            return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
        }
        err = err__prev1;

    }
    err = default!;
    net.Conn c = default;
    if (d.ProxyDial != null) {
        c, err = d.ProxyDial(context.Background(), d.proxyNetwork, d.proxyAddress);
    }
    else
 {
        c, err = net.Dial(d.proxyNetwork, d.proxyAddress);
    }
    if (err != null) {
        (proxy, dst, _) = d.pathAddrs(address);
        return (null, error.As(addr(new net.OpError(Op:d.cmd.String(),Net:network,Source:proxy,Addr:dst,Err:err))!)!);
    }
    {
        var err__prev1 = err;

        var (_, err) = d.DialWithConn(context.Background(), c, network, address);

        if (err != null) {
            c.Close();
            return (null, error.As(err)!);
        }
        err = err__prev1;

    }
    return (c, error.As(null!)!);
}

private static error validateTarget(this ptr<socksDialer> _addr_d, @string network, @string address) {
    ref socksDialer d = ref _addr_d.val;

    switch (network) {
        case "tcp": 

        case "tcp6": 

        case "tcp4": 

            break;
        default: 
            return error.As(errors.New("network not implemented"))!;
            break;
    }

    if (d.cmd == socksCmdConnect || d.cmd == sockscmdBind)     else 
        return error.As(errors.New("command not implemented"))!;
        return error.As(null!)!;
}

private static (net.Addr, net.Addr, error) pathAddrs(this ptr<socksDialer> _addr_d, @string address) {
    net.Addr proxy = default;
    net.Addr dst = default;
    error err = default!;
    ref socksDialer d = ref _addr_d.val;

    foreach (var (i, s) in new slice<@string>(new @string[] { d.proxyAddress, address })) {
        var (host, port, err) = sockssplitHostPort(s);
        if (err != null) {
            return (null, null, error.As(err)!);
        }
        ptr<socksAddr> a = addr(new socksAddr(Port:port));
        a.IP = net.ParseIP(host);
        if (a.IP == null) {
            a.Name = host;
        }
        if (i == 0) {
            proxy = a;
        }
        else
 {
            dst = a;
        }
    }    return ;
}

// NewDialer returns a new Dialer that dials through the provided
// proxy server's network and address.
private static ptr<socksDialer> socksNewDialer(@string network, @string address) {
    return addr(new socksDialer(proxyNetwork:network,proxyAddress:address,cmd:socksCmdConnect));
}

private static readonly nuint socksauthUsernamePasswordVersion = 0x01;
private static readonly nuint socksauthStatusSucceeded = 0x00;

// UsernamePassword are the credentials for the username/password
// authentication method.
private partial struct socksUsernamePassword {
    public @string Username;
    public @string Password;
}

// Authenticate authenticates a pair of username and password with the
// proxy server.
private static error Authenticate(this ptr<socksUsernamePassword> _addr_up, context.Context ctx, io.ReadWriter rw, socksAuthMethod auth) {
    ref socksUsernamePassword up = ref _addr_up.val;


    if (auth == socksAuthMethodNotRequired) 
        return error.As(null!)!;
    else if (auth == socksAuthMethodUsernamePassword) 
        if (len(up.Username) == 0 || len(up.Username) > 255 || len(up.Password) == 0 || len(up.Password) > 255) {
            return error.As(errors.New("invalid username/password"))!;
        }
        byte b = new slice<byte>(new byte[] { socksauthUsernamePasswordVersion });
        b = append(b, byte(len(up.Username)));
        b = append(b, up.Username);
        b = append(b, byte(len(up.Password)));
        b = append(b, up.Password); 
        // TODO(mikio): handle IO deadlines and cancelation if
        // necessary
        {
            var (_, err) = rw.Write(b);

            if (err != null) {
                return error.As(err)!;
            }

        }
        {
            (_, err) = io.ReadFull(rw, b[..(int)2]);

            if (err != null) {
                return error.As(err)!;
            }

        }
        if (b[0] != socksauthUsernamePasswordVersion) {
            return error.As(errors.New("invalid username/password version"))!;
        }
        if (b[1] != socksauthStatusSucceeded) {
            return error.As(errors.New("username/password authentication failed"))!;
        }
        return error.As(null!)!;
        return error.As(errors.New("unsupported authentication method " + strconv.Itoa(int(auth))))!;
}

} // end http_package
