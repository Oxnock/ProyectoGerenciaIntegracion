#pragma checksum "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7390d637647732cfe89a5f1e092da42c1472dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mauricio_Familia), @"mvc.1.0.view", @"/Views/Mauricio/Familia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mauricio/Familia.cshtml", typeof(AspNetCore.Views_Mauricio_Familia))]
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
#line 1 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
using SampleMvcApp.Models.Mauricio;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7390d637647732cfe89a5f1e092da42c1472dde", @"/Views/Mauricio/Familia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e3215a5f67ad76e6da6f8e7dee53382bd3c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Mauricio_Familia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SampleMvcApp.Models.Mauricio.Consulta>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
  
    ViewData["Title"] = "Familia";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 56, true);
            WriteLiteral("<!DOCTYPE html>\r\n<h2>Familias</h2>\r\n\r\n<HTML lang=\"en\">\r\n");
            EndContext();
            BeginContext(230, 675, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46f08dbd520445c3af44cf08d1fcbb50", async() => {
                BeginContext(236, 522, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>

    <style>

        #myInput {
            float: left;
            margin-right: 60px;
        }
    </style>
");
                EndContext();
                BeginContext(896, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(905, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(918, 2074, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1fae73b51a543c0b0283f6b76caf3fe", async() => {
                BeginContext(924, 408, true);
                WriteLiteral(@"
        <div class=""container"">
            <div>
                <input class=""form-control"" id=""myInput"" type=""text"" placeholder=""Search.."">
                <button class=""btn btn-primary  dropdown-toggle"" type=""button"" data-toggle=""dropdown"">
                    Dropdown Example
                    <span class=""caret""></span>
                </button>
            </div>
            <br>


");
                EndContext();
#line 46 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
             foreach (SampleMvcApp.Models.Mauricio.Familia familia in Model.GetFamilias())
            {

#line default
#line hidden
                BeginContext(1439, 92, true);
                WriteLiteral("                <div class=\"alert-info\">\r\n\r\n                    <p><strong>Nombre: </strong>");
                EndContext();
                BeginContext(1532, 19, false);
#line 50 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
                                           Write(familia.GetNombre());

#line default
#line hidden
                EndContext();
                BeginContext(1551, 59, true);
                WriteLiteral("</p>\r\n                    <p><strong>Descripcion: </strong>");
                EndContext();
                BeginContext(1611, 24, false);
#line 51 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
                                                Write(familia.GetDescripcion());

#line default
#line hidden
                EndContext();
                BeginContext(1635, 28, true);
                WriteLiteral("</p>\r\n\r\n                    ");
                EndContext();
                BeginContext(1664, 84, false);
#line 53 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
               Write(Html.ActionLink("Eliminar", "FamiliaEliminar", new { nombre = familia.GetNombre() }));

#line default
#line hidden
                EndContext();
                BeginContext(1748, 50, true);
                WriteLiteral("\r\n                </div>\r\n                <hr />\r\n");
                EndContext();
#line 63 "C:\Users\jsezu\Documents\GitHub\Gerencia\01-login\Views\Mauricio\Familia.cshtml"
                                                             

            }

#line default
#line hidden
                BeginContext(2088, 897, true);
                WriteLiteral(@"

            <a class=""btn btn-primary"" href=""#"" role=""button"">Agregar</a>
        </div>
        <script>
    $(document).ready(function () {
                $(""#myInput"").on(""keyup"", function () {
                    var value = $(this).val().toLowerCase();
                    $(""#myTable tr"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });</script>
        <script>
    $(document).ready(function () {
                $(""#myInput"").on(""keyup"", function () {
                    var value = $(this).val().toLowerCase();
                    $("".dropdown-menu li"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });</script>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2992, 19, true);
            WriteLiteral("\r\n</div>\r\n</HTML>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleMvcApp.Models.Mauricio.Consulta> Html { get; private set; }
    }
}
#pragma warning restore 1591