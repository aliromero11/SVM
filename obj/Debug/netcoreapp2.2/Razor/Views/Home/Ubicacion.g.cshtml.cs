#pragma checksum "C:\Users\jheds\Desktop\SVM\SVM\Views\Home\Ubicacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493639d4ecd498f3cab5258843bfd6b4c3db24d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ubicacion), @"mvc.1.0.view", @"/Views/Home/Ubicacion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Ubicacion.cshtml", typeof(AspNetCore.Views_Home_Ubicacion))]
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
using SVM.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\jheds\Desktop\SVM\SVM\Views\_ViewImports.cshtml"
using SVM.Models.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493639d4ecd498f3cab5258843bfd6b4c3db24d2", @"/Views/Home/Ubicacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0acb60e64c4a38f68441488568dd7d2168f67b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ubicacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 154, true);
            WriteLiteral("\r\n <section > \r\n        <div class=\"container \">\r\n             <div class=\"row\">\r\n                   <div class=\"col-lg-12\">\r\n                       <h1> ");
            EndContext();
            BeginContext(155, 17, false);
#line 6 "C:\Users\jheds\Desktop\SVM\SVM\Views\Home\Ubicacion.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 1111, true);
            WriteLiteral(@"</h1>
                         
                      <div class=""texto-acerca-map"">
                            <p>
                                Avenida ......
                                Sotano, Puesto 202
                            </p>
                            <p>
                                <a href=""mailto:edwar.salas.987@gmail.com"">
                                    Click aqui, para esribirnos un correo
                                </a> 
                             </p>
                      </div>
                   </div>
               
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d975.4168396491177!2d-77.0123469747664!3d-12.06639294439542!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x9105c89e5d3584f9%3A0x80686f9e926a7257!2sCalle+Sebasti%C3%A1n+Barranca+1691%2C+La+Victoria+15018!5e0!3m2!1ses-419!2spe!4v1556348217281!5m2!1ses-419!2spe""  width=""100%"" height=""450"" frameborder=""0"" style=""border:0; padding: 1rem 0"" allowful");
            WriteLiteral("lscreen></iframe>\r\n                \r\n            </div>\r\n        </div>\r\n </section>\r\n ");
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
