#pragma checksum "C:\Users\jheds\Desktop\SVM\SVM\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79ba2b2824a18d06997ef826ec60d3e88795991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lockout), @"mvc.1.0.view", @"/Views/Account/Lockout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Lockout.cshtml", typeof(AspNetCore.Views_Account_Lockout))]
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
#line 1 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using SVM;

#line default
#line hidden
#line 3 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using SVM.Models;

#line default
#line hidden
#line 4 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using SVM.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using SVM.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79ba2b2824a18d06997ef826ec60d3e88795991", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6684832e0231a267ee07379d3d12be232c488288", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\jheds\Desktop\SVM\SVM\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
            BeginContext(43, 38, true);
            WriteLiteral("\n<header>\n    <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(82, 17, false);
#line 6 "C:\Users\jheds\Desktop\SVM\SVM\Views\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 105, true);
            WriteLiteral("</h2>\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
