#pragma checksum "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f1171e5f76159065d14780779bb00e8ac16e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
#line 1 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
using PortifolioMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f1171e5f76159065d14780779bb00e8ac16e03", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddc1974bab832d1831a586dc3882494856207bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortifolioMVC.Models.Aula>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
  
    ViewData["Title"] = "Aulas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""contato"" >
    <div class=""container"">
        <h1>Aulas do Portifolio</h1>
        <div class=""row"">
   
         <div class=""col-md-12 "">
               <div class=""card-group"">
                 <div class=""card"">
                   <img src=""https://img.youtube.com/vi/x4FdZd2-_uU/maxresdefault.jpg"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body"">
                    <h5 class=""card-title""> <a href=""https://youtu.be/x4FdZd2-_uU"" target=""_blank"">Visualizar aula 1</a></h5>
                    <p class=""card-text"">57 min.</p>
                    <p class=""card-text""><small class=""text-muted"">Free</small></p>
                    </div>
                 </div>
                    <div class=""card"">
                        <img src=""https://img.youtube.com/vi/GykTLqODQuU/maxresdefault.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                        <h5 class=""card-title""><a href=""https://youtu.be/GykTLqODQuU");
            WriteLiteral(@" "" target=""_blank"">Visualizar aula 2</a></h5>
                        <p class=""card-text"">57 min.</p>
                        <p class=""card-text""><small class=""text-muted"">Free</small></p>
                        </div>
                    </div>
                <div class=""card"">
                        <img src=""https://img.youtube.com/vi/HN1UjzRSdBk/maxresdefault.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                        <h5 class=""card-title""> <a href=""https://youtu.be/HN1UjzRSdBk"" target=""_blank"">Visualizar aula 3</a> </h5>
                        <p class=""card-text"">57 min.</p>
                        <p class=""card-text""><small class=""text-muted"">Free</small></p>
                        </div>
                    </div>
            </div>
        </div>
       
        <div class=""row"">
");
#nullable restore
#line 44 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
           foreach (Aula aula in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"col-md-4 \">\r\n               <div class=\"card-group\">\r\n                 <div class=\"card\">\r\n                   <img");
            BeginWriteAttribute("src", " src=\"", 2239, "\"", 2260, 1);
#nullable restore
#line 49 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
WriteAttributeValue("", 2245, aula.ImagemUrl, 2245, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"> <a");
            BeginWriteAttribute("href", " href=\"", 2386, "\"", 2407, 1);
#nullable restore
#line 51 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
WriteAttributeValue("", 2393, aula.VideoUrl, 2393, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Visualizar ");
#nullable restore
#line 51 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
                                                                                           Write(aula.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 52 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
                                    Write(aula.Duracao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 53 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
                                                              Write(aula.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</small></p>\r\n                    </div>\r\n                 </div>\r\n                   \r\n                \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 60 "C:\Users\tgsv\Downloads\PortifolioMVC2 (2)\PortifolioMVC2\PortifolioMVC\Views\Home\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortifolioMVC.Models.Aula>> Html { get; private set; }
    }
}
#pragma warning restore 1591
