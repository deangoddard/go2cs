// Code generated by "stringer -type urlPart"; DO NOT EDIT.

// package template -- go2cs converted at 2022 March 06 22:25:40 UTC
// import "html/template" ==> using template = go.html.template_package
// Original source: C:\Program Files\Go\src\html\template\urlpart_string.go
using strconv = go.strconv_package;

namespace go.html;

public static partial class template_package {

private static readonly @string _urlPart_name = "urlPartNoneurlPartPreQueryurlPartQueryOrFragurlPartUnknown";



private static array<byte> _urlPart_index = new array<byte>(new byte[] { 0, 11, 26, 44, 58 });

private static @string String(this urlPart i) {
    if (i >= urlPart(len(_urlPart_index) - 1)) {
        return "urlPart(" + strconv.FormatInt(int64(i), 10) + ")";
    }
    return _urlPart_name[(int)_urlPart_index[i]..(int)_urlPart_index[i + 1]];

}

} // end template_package
