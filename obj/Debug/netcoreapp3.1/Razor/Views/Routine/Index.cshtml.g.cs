#pragma checksum "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0a44a15c0bfbb9f846587655c784f2b6f3b6e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Routine_Index), @"mvc.1.0.view", @"/Views/Routine/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\joshu\source\repos\DiarsT3\Views\_ViewImports.cshtml"
using DiarsT3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshu\source\repos\DiarsT3\Views\_ViewImports.cshtml"
using DiarsT3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0a44a15c0bfbb9f846587655c784f2b6f3b6e2", @"/Views/Routine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0636de57f217688880bb510093d5341c79efc41a", @"/Views/_ViewImports.cshtml")]
    public class Views_Routine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DiarsT3.Models.Routine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 style=""text-align:center"">Mis rutinas</h1>

<div class=""row mb-3"">
    <div class=""col"">
        <a href=""/Routine/Register"" class=""btn btn-success"">Registrar rutina</a>
    </div>
</div>

<div class=""row"">
    <div class=""col-12"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Rutina</th>
                    <th>Duración</th>
                    <th>Info</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml"
                 foreach (var rutina in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 25 "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml"
                       Write(rutina.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 26 "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml"
                       Write(rutina.CalcularDuracion());

#line default
#line hidden
#nullable disable
            WriteLiteral(" segundos </td>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 816, 2);
            WriteAttributeValue("", 790, "/Routine/Detail/", 790, 16, true);
#nullable restore
#line 28 "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml"
WriteAttributeValue("", 806, rutina.Id, 806, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Detalle</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 31 "C:\Users\joshu\source\repos\DiarsT3\Views\Routine\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DiarsT3.Models.Routine>> Html { get; private set; }
    }
}
#pragma warning restore 1591