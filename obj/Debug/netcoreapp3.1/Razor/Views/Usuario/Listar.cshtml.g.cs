#pragma checksum "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ba9b081a8234df1db8661d158bd4316d2a3e08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
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
#line 1 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\_ViewImports.cshtml"
using PortifolioMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
using PortifolioMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ba9b081a8234df1db8661d158bd4316d2a3e08", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddc1974bab832d1831a586dc3882494856207bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortifolioMVC.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
  
    ViewData["Title"] = "Aulas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""contato"">
    <div class=""container"">
        <table class=""table table-striped"">
  <thead>
    <tr>
     <tr>
            <th scope=""col"">Id do Usuário</th>
            <th scope=""col"">Nome do Usuário</th>
            <th scope=""col"">Login do Usuário</th>
            <th scope=""col"">Senha do Usuário</th>
            <th scope=""col"">Tipo de Usuário</th>
");
#nullable restore
#line 19 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
              foreach (Usuario usuario in Model){
                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                   if(usuario.tipousuario == "Administrador"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <th>Ações</th>\r\n");
#nullable restore
#line 22 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
              
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
         foreach (Usuario usuario in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
               Write(usuario.idusuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
               Write(usuario.nomeusuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
               Write(usuario.senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
               Write(usuario.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                 if(usuario.tipousuario == "Administrador"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 36 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                }else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                       if(usuario.tipousuario == "Aluno"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <td>Aluno</td>\r\n");
#nullable restore
#line 38 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                  if(usuario.tipousuario == "Administrador"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a style=\"text-decoration=none; color=white; font-weight: bold; \"");
            BeginWriteAttribute("href", " href=\"", 1395, "\"", 1430, 2);
            WriteAttributeValue("", 1402, "Editar?Id=", 1402, 10, true);
#nullable restore
#line 42 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1412, usuario.idusuario, 1412, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Editar </a> |                \r\n                    <a style=\"text-decoration=none; color=white; font-weight: bold; \"");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1585, 2);
            WriteAttributeValue("", 1556, "Remover?Id=", 1556, 11, true);
#nullable restore
#line 43 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1567, usuario.idusuario, 1567, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Deletar</a>\r\n                </td>\r\n");
#nullable restore
#line 45 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Usuario\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortifolioMVC.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
