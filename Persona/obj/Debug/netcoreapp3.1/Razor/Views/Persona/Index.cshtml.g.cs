#pragma checksum "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d4b9603e483fdd0b60eada1886baf8616cbcce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
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
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\_ViewImports.cshtml"
using Persona;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\_ViewImports.cshtml"
using Persona.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d4b9603e483fdd0b60eada1886baf8616cbcce", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cadad7fbe7675bb54db53bc3fa1683ae6a1c555", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
   List<Personas> persona = ((List<Personas>)Model); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista Personas</h1>
<a href=""/persona/create"" class=""badge badge-succes"">Registrar</a>
<table class=""table table-dark"">
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Fecha de Nacimiento</th>
            <th>DNI</th>
            <th>Genero</th>
            <th>Ciudad</th>
            <th>Direccion</th>
            <th>Email</th>
            <th>Username</th>
            <th>Contraseña</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
         for (int i = 0; i < persona.Count; i++)
        {
            Personas item = persona[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 26 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.FechaNac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.NomCiudad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 32 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
           Write(item.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1105, 2);
            WriteAttributeValue("", 1080, "/Persona/edit?id=", 1080, 17, true);
#nullable restore
#line 37 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
WriteAttributeValue("", 1097, item.Id, 1097, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge badge-warning\">Editar</a> /\n                <a");
            BeginWriteAttribute("href", " href=\"", 1166, "\"", 1200, 2);
            WriteAttributeValue("", 1173, "/Persona/delete?id=", 1173, 19, true);
#nullable restore
#line 38 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
WriteAttributeValue("", 1192, item.Id, 1192, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge badge-warning\">Eliminar</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 41 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 4\T1\Examen\Persona\Persona\Views\Persona\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
