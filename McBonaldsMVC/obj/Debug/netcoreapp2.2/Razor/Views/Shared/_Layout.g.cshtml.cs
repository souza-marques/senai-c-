#pragma checksum "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19be1c310311ac4b7d37f285b4614b3cf3061bc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19be1c310311ac4b7d37f285b4614b3cf3061bc0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-secondary-pages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-form-pages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
  
    var nomeView = (string) ViewData["NomeView"];//como se fosse um dicionário, guarda Objeto;

#line default
#line hidden
            BeginContext(103, 42, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(145, 1098, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19be1c310311ac4b7d37f285b4614b3cf3061bc07976", async() => {
                BeginContext(151, 604, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <!-- PASSOS DO MENU RESPONSIVO -->
    <!-- PASSO 1 - Certifique-se de que essa linha abaixo existe no seu código -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>McBonald's</title>
    <link href=""img/logo_simbolo.png"" rel=""icon"" type=""image/x-icon""/>
    <link href=""https://fonts.googleapis.com/css?family=Fredoka+One&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Londrina+Solid:900%7COpen+Sans"" rel=""stylesheet"">
    ");
                EndContext();
                BeginContext(755, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19be1c310311ac4b7d37f285b4614b3cf3061bc08984", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(817, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
     if(!"Home".Equals(nomeView))
    {

#line default
#line hidden
                BeginContext(861, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(869, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19be1c310311ac4b7d37f285b4614b3cf3061bc010688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(947, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(957, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19be1c310311ac4b7d37f285b4614b3cf3061bc012114", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1030, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
                BeginContext(1039, 197, true);
                WriteLiteral("    <!-- PASSO 2 - Copie a linha do <script> abaixo para o seu HTML -->\r\n    <!-- Importar o Font Awesome para o projeto -->\r\n    <script src=\"https://kit.fontawesome.com/349a64cb04.js\"></script>\r\n");
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
            BeginContext(1243, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1247, 3372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19be1c310311ac4b7d37f285b4614b3cf3061bc014792", async() => {
                BeginContext(1276, 716, true);
                WriteLiteral(@"
    <header>
        <nav>
            <div class=""section-container"">
                <ul>
                    <!-- PASSO 3 - Adicione esse li à sua ul -->
                    <li id=""bt-mobile-menu"">
                        <!-- HTML para colocar os ícones do FA -->
                        <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                            <i class=""fa fa-bars""></i>
                        </a>
                    </li>
                    <!-- PASSO 4 - Adicione essa class=""bt-common-menu"" nas suas li -->
                    <!-- PASSO 5 - Adicione o onclick=""toggleMobileMenu()"" nas tags a -->
                    <li class=""bt-common-menu"">");
                EndContext();
                BeginContext(1992, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19be1c310311ac4b7d37f285b4614b3cf3061bc015910", async() => {
                    BeginContext(2080, 9, true);
                    WriteLiteral("Principal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2093, 85, true);
                WriteLiteral("</li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2178, "\'", 2225, 2);
#line 44 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2185, Url.Action("Index","Home"), 2185, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 2212, "#hamburgueres", 2212, 13, true);
                EndWriteAttribute();
                BeginContext(2226, 102, true);
                WriteLiteral(">Hamburgueres</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2328, "\'", 2369, 2);
#line 45 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2335, Url.Action("Index","Home"), 2335, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 2362, "#shakes", 2362, 7, true);
                EndWriteAttribute();
                BeginContext(2370, 96, true);
                WriteLiteral(">Shakes</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2466, "\'", 2509, 2);
#line 46 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2473, Url.Action("Index","Home"), 2473, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 2500, "#historia", 2500, 9, true);
                EndWriteAttribute();
                BeginContext(2510, 98, true);
                WriteLiteral(">História</a></li>\r\n                    <li class=\"bt-common-menu\"><a onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2608, "\'", 2648, 2);
#line 47 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2615, Url.Action("Index","Home"), 2615, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 2642, "#local", 2642, 6, true);
                EndWriteAttribute();
                BeginContext(2649, 64, true);
                WriteLiteral(">Local</a></li>\r\n                    <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(2713, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19be1c310311ac4b7d37f285b4614b3cf3061bc020273", async() => {
                    BeginContext(2789, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2798, 224, true);
                WriteLiteral("</li>\r\n                    <li><a id=\"bt-peca_ja\" href=\"pedidos.html\">Peça já!</a></li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n       <!-- Comentário para eu não esquecer de colocar aqui o logo área-->\r\n");
                EndContext();
#line 54 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
        if("Home".Equals(nomeView))
       {
           Html.RenderPartial("_HeaderHomePage");
       }

#line default
#line hidden
                BeginContext(3130, 29, true);
                WriteLiteral("    </header>\r\n\r\n            ");
                EndContext();
                BeginContext(3160, 12, false);
#line 60 "C:\Users\52450072829\Documents\exercícios2\McBonaldsMVC\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3172, 1440, true);
                WriteLiteral(@"
 <footer>
        <div class=""section-container"">
            <address>
                Avenida de Limeira, 539 - Campos Elíseos - SP
                <br />
                mcbonalds@email.com
                <br />
                11 1234 6789
            </address>
            <a href=""#"">Voltar para o topo!</a>
        </div>
    </footer>

    <!-- PASSO 6 - Adicione a tag script e seu conteúdo antes do body fechar -->
    <!-- Agora vá para o style.css desse projeto! -->
    <script>
        function toggleMobileMenu() {
            var ul = document.querySelector(""nav ul"");
            var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
            var icon = document.querySelector("".icon > i"");

            ul.classList.toggle(""mobile-mode"");

            if (icon.classList.contains(""fa-bars"")) {
                icon.classList.remove(""fa-bars"");
                icon.classList.remove(""fa"");

                icon.classList.add(""fas"");
                icon.c");
                WriteLiteral(@"lassList.add(""fa-skull"");
            } else {
                icon.classList.remove(""fas"");
                icon.classList.remove(""fa-skull"");

                icon.classList.add(""fa"");
                icon.classList.add(""fa-bars"");
            }

            for (var button of commonButtons) {
                button.classList.toggle(""active"");
            }

        }
        
    </script>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4619, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
