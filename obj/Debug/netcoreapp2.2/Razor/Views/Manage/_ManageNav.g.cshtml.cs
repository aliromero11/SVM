#pragma checksum "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a4d923e6c744f2dc043631004fe53f86c98e9f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__ManageNav), @"mvc.1.0.view", @"/Views/Manage/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_ManageNav.cshtml", typeof(AspNetCore.Views_Manage__ManageNav))]
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
#line 1 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\_ViewImports.cshtml"
using SVM;

#line default
#line hidden
#line 3 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\_ViewImports.cshtml"
using SVM.Models;

#line default
#line hidden
#line 4 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\_ViewImports.cshtml"
using SVM.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\_ViewImports.cshtml"
using SVM.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
using IdentityDemo.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4d923e6c744f2dc043631004fe53f86c98e9f4", @"/Views/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6684832e0231a267ee07379d3d12be232c488288", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24be2142b27d1521c359945ffe5f046acd2c6866", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TwoFactorAuthentication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
            BeginContext(193, 93, true);
            WriteLiteral(" \r\n \r\n    <ul class=\"nav nav-pills nav-stacked \" style=\"display: inline-block;\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 286, "\"", 355, 3);
#line 9 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 294, ManageNavPages.IndexNavClass(ViewContext), 294, 42, false);

#line default
#line hidden
            WriteAttributeValue(" ", 336, "navbar-nav", 337, 11, true);
            WriteAttributeValue(" ", 347, "ml-auto", 348, 8, true);
            EndWriteAttribute();
            BeginContext(356, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(357, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4d923e6c744f2dc043631004fe53f86c98e9f46552", async() => {
                BeginContext(401, 6, true);
                WriteLiteral("Perfil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(411, 18, true);
            WriteLiteral("</li>\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 429, "\"", 507, 3);
#line 10 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 437, ManageNavPages.ChangePasswordNavClass(ViewContext), 437, 51, false);

#line default
#line hidden
            WriteAttributeValue(" ", 488, "navbar-nav", 489, 11, true);
            WriteAttributeValue(" ", 499, "ml-auto", 500, 8, true);
            EndWriteAttribute();
            BeginContext(508, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(509, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4d923e6c744f2dc043631004fe53f86c98e9f48605", async() => {
                BeginContext(562, 10, true);
                WriteLiteral("Contraseña");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(576, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
         if (hasExternalLogins)
        {

#line default
#line hidden
            BeginContext(627, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 638, "\"", 716, 3);
#line 13 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 646, ManageNavPages.ExternalLoginsNavClass(ViewContext), 646, 51, false);

#line default
#line hidden
            WriteAttributeValue(" ", 697, "navbar-nav", 698, 11, true);
            WriteAttributeValue(" ", 708, "ml-auto", 709, 8, true);
            EndWriteAttribute();
            BeginContext(717, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(718, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4d923e6c744f2dc043631004fe53f86c98e9f410940", async() => {
                BeginContext(771, 26, true);
                WriteLiteral("Inicios de sesión externos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
        }

#line default
#line hidden
            BeginContext(819, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 830, "\"", 917, 3);
#line 15 "C:\Users\EdgardCalderon\Desktop\Programacion I\Proyecto\SVM\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 838, ManageNavPages.TwoFactorAuthenticationNavClass(ViewContext), 838, 60, false);

#line default
#line hidden
            WriteAttributeValue(" ", 898, "navbar-nav", 899, 11, true);
            WriteAttributeValue(" ", 909, "ml-auto", 910, 8, true);
            EndWriteAttribute();
            BeginContext(918, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(919, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4d923e6c744f2dc043631004fe53f86c98e9f413268", async() => {
                BeginContext(981, 30, true);
                WriteLiteral("Autenticación de dos factores ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1015, 23, true);
            WriteLiteral("</li>\r\n    </ul>\r\n \r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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