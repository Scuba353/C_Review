#pragma checksum "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/Home/Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2486e44299a6fc8526c0edae46a8af1b06fd088"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Numbers.cshtml", typeof(AspNetCore.Views_Home_Numbers))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/_ViewImports.cshtml"
using MVCapp;

#line default
#line hidden
#line 1 "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/Home/Numbers.cshtml"
using MVCapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2486e44299a6fc8526c0edae46a8af1b06fd088", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebc124ce2b6d6335131dfbc906dc321149a24d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/Home/Numbers.cshtml"
 foreach(var num in Model){

#line default
#line hidden
            BeginContext(69, 20, true);
            WriteLiteral("    <p>My number is ");
            EndContext();
            BeginContext(90, 3, false);
#line 5 "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/Home/Numbers.cshtml"
               Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(93, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 6 "/Users/allysefischer/Desktop/C#Review/MVCapp/Views/Home/Numbers.cshtml"
}

#line default
#line hidden
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
