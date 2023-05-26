#pragma checksum "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4478e61b22ccad133c8815919edcdf58a9ab9ba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario__ContatosUsuario), @"mvc.1.0.view", @"/Views/Usuario/_ContatosUsuario.cshtml")]
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
#line 1 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4478e61b22ccad133c8815919edcdf58a9ab9ba2", @"/Views/Usuario/_ContatosUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario__ContatosUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""display"" id=""table-contatos-usuario"" style=""width:100%"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">E-mail</th>
            <th scope=""col"">Celular</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 13 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var contato in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 18 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
                               Write(contato.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 19 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
                   Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
                   Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
                   Write(contato.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"odd\"><td valign=\"top\" colspan=\"4\">Nenhum contato encontrado</td></tr>\r\n");
#nullable restore
#line 28 "D:\Gustavo\Projetos\ControleDeContatos\ControleDeContatos\Views\Usuario\_ContatosUsuario.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591