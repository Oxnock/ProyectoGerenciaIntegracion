#pragma checksum "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794f3277b5059c2776a212b067dabe1cb7fb9eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\_ViewImports.cshtml"
using SampleMvcApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794f3277b5059c2776a212b067dabe1cb7fb9eb0", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e3215a5f67ad76e6da6f8e7dee53382bd3c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SampleMvcApp.Models.ProfileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 41, true);
            WriteLiteral("<!-- Views/Account/Profile.cshtml -->\r\n\r\n");
            EndContext();
#line 4 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
            BeginContext(124, 93, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n            <h2>");
            EndContext();
            BeginContext(218, 17, false);
#line 11 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Account\Profile.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(235, 64, true);
            WriteLiteral(".</h2>\r\n            <div class=\"col-md-4\">\r\n                <h3>");
            EndContext();
            BeginContext(300, 10, false);
#line 13 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Account\Profile.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(310, 93, true);
            WriteLiteral("</h3>\r\n                <p>\r\n                    <i class=\"glyphicon glyphicon-envelope\"></i> ");
            EndContext();
            BeginContext(404, 18, false);
#line 15 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Account\Profile.cshtml"
                                                            Write(Model.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(422, 78, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleMvcApp.Models.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
