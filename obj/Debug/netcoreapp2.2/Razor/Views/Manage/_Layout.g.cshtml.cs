#pragma checksum "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92dcbb5c5b2c85f97f797ccdc9c00de43840902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
#line 1 "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_ViewImports.cshtml"
using IdentityDemo.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92dcbb5c5b2c85f97f797ccdc9c00de43840902", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6684832e0231a267ee07379d3d12be232c488288", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24be2142b27d1521c359945ffe5f046acd2c6866", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(51, 217, true);
            WriteLiteral("\n<div class=\"container\">\n    <h2>Maneja tu cuenta</h2>\n    \n    <div>\n        <h4>Cambiar la configuración de su cuenta</h4>\n        <hr />\n        <div class=\"row\">\n            <div class=\"col-md-3\">\n                ");
            EndContext();
            BeginContext(269, 37, false);
#line 13 "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_Layout.cshtml"
           Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
            EndContext();
            BeginContext(306, 71, true);
            WriteLiteral("\n            </div>\n            <div class=\"col-md-9\">\n                ");
            EndContext();
            BeginContext(378, 12, false);
#line 16 "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(390, 58, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    \n</div>\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(466, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(472, 41, false);
#line 23 "C:\Users\jheds\Desktop\SVM\SVM\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(513, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(516, 9, true);
            WriteLiteral("        \n");
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
