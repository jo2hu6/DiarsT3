#pragma checksum "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210cf99a1ecb866fd36e9500e18751ec2d0a949e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rutina_Detalle), @"mvc.1.0.view", @"/Views/Rutina/Detalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210cf99a1ecb866fd36e9500e18751ec2d0a949e", @"/Views/Rutina/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0636de57f217688880bb510093d5341c79efc41a", @"/Views/_ViewImports.cshtml")]
    public class Views_Rutina_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiarsT3.Models.Rutina>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h3>Rutina: ");
#nullable restore
#line 3 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Tipo: ");
#nullable restore
#line 3 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
                             Write(Model.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>


<div class=""row"">
    <div class=""col-12"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Ejercicio</th>
                    <th>Link Youtube</th>
                    <th>Duración</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
                 foreach (var ejercicio in Model.EjercicioRutinas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 20 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
       Write(ejercicio.Ejercicio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n        <td>");
#nullable restore
#line 21 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
       Write(ejercicio.Ejercicio.LinkYoutube);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n        <td>");
#nullable restore
#line 22 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
       Write(ejercicio.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" segundos</td>\n    </tr>");
#nullable restore
#line 23 "C:\Users\joshu\source\repos\DiarsT3\Views\Rutina\Detalle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiarsT3.Models.Rutina> Html { get; private set; }
    }
}
#pragma warning restore 1591
