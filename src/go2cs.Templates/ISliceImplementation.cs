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
    
    #line 1 "C:\Projects\go2cs\src\go2cs.Templates\ISliceImplementation.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ISliceImplementation : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "C:\Projects\go2cs\src\go2cs.Templates\ISliceImplementation.tt"
 // This template creates an inherited type, e.g., type MyFloat float64 in a <PackageName>_<StructName>StructOf(<GoTypeName>).cs file 
            
            #line default
            #line hidden
            this.Write(@"
            public Array Array => ((ISlice)m_value).Array;

            public nint Low => ((ISlice)m_value).Low;

            public nint High => ((ISlice)m_value).High;

            public nint Capacity => ((ISlice)m_value).Capacity;

            public nint Available => ((ISlice)m_value).Available;

            public nint Length => ((IArray)m_value).Length;

            object? IArray.this[nint index]
            {
                get => ((IArray)m_value)[index];
                set => ((IArray)m_value)[index] = value;
            }
            
            public ref ");
            
            #line 23 "C:\Projects\go2cs\src\go2cs.Templates\ISliceImplementation.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write(@" this[nint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => ref m_value[index];
            }
            
            public ISlice? Append(object[] elems) => ((ISlice)m_value).Append(elems);

            public IEnumerator GetEnumerator() => ((IEnumerable)m_value).GetEnumerator();

            public object Clone() => ((ICloneable)m_value).Clone();
");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 34 "C:\Projects\go2cs\src\go2cs.Templates\ISliceImplementation.tt"

// Template Parameters
public string TypeName;

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
