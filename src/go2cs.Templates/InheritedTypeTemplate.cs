﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace go2cs.Templates
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class InheritedTypeTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
 // This template creates an inherited type, e.g., type MyFloat float64 in a <PackageName>_<StructName>StructOf(<GoTypeName>).cs file 
            
            #line default
            #line hidden
            this.Write(@"//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on ");
            
            #line 10 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedTime));
            
            #line default
            #line hidden
            this.Write("\r\n// </auto-generated>\r\n//-------------------------------------------------------" +
                    "--\r\nusing System.CodeDom.Compiler;\r\nusing System.Runtime.CompilerServices;\r\n");
            
            #line 15 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
if (!NamespacePrefix.Equals("go")) {
            
            #line default
            #line hidden
            this.Write("using go;\r\n");
            
            #line 17 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n#nullable enable\r\n\r\n");
            
            #line 21 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceHeader));
            
            #line default
            #line hidden
            this.Write("\r\n    public static partial class ");
            
            #line 22 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package\r\n    {\r\n        [");
            
            #line 24 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            
            #line default
            #line hidden
            this.Write("]\r\n        ");
            
            #line 25 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Scope));
            
            #line default
            #line hidden
            this.Write(" partial struct ");
            
            #line 25 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            // Value of the ");
            
            #line 27 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" struct\r\n            private readonly ");
            
            #line 28 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" m_value;\r\n\r\n            public ");
            
            #line 30 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 30 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" value) => m_value = value;\r\n\r\n            // Enable implicit conversions between" +
                    " ");
            
            #line 32 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" and ");
            
            #line 32 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" struct\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n        " +
                    "    public static implicit operator ");
            
            #line 34 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 34 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(" value) => new ");
            
            #line 34 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(value);\r\n            \r\n            [MethodImpl(MethodImplOptions.AggressiveInlin" +
                    "ing)]\r\n            public static implicit operator ");
            
            #line 37 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 37 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value) => value.m_value;\r\n            \r\n            // Enable comparisons betwee" +
                    "n nil and ");
            
            #line 39 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" struct\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n        " +
                    "    public static bool operator ==(");
            
            #line 41 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => value.Equals(default(");
            
            #line 41 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("));\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n          " +
                    "  public static bool operator !=(");
            
            #line 44 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => !(value == nil);\r\n\r\n            [MethodImpl(MethodImplOpt" +
                    "ions.AggressiveInlining)]\r\n            public static bool operator ==(NilType ni" +
                    "l, ");
            
            #line 47 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value) => value == nil;\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveI" +
                    "nlining)]\r\n            public static bool operator !=(NilType nil, ");
            
            #line 50 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value) => value != nil;\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveI" +
                    "nlining)]\r\n            public static implicit operator ");
            
            #line 53 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(NilType nil) => default(");
            
            #line 53 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n    }\r\n");
            
            #line 56 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceFooter));
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 57 "D:\Projects\go2cs\src\go2cs.Templates\InheritedTypeTemplate.tt"

// Template Parameters
public string NamespacePrefix;
public string NamespaceHeader;
public string NamespaceFooter;
public string PackageName;
public string StructName;
public string Scope;
public string TypeName;

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
