#pragma checksum "C:\Users\Taila\Downloads\MVC_AspNetCore_ProjetoEPlayers-main\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74ecb9b2c642a7085cc5adac52e1b82ebee90f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Taila\Downloads\MVC_AspNetCore_ProjetoEPlayers-main\Views\_ViewImports.cshtml"
using EPlayers_AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Taila\Downloads\MVC_AspNetCore_ProjetoEPlayers-main\Views\_ViewImports.cshtml"
using EPlayers_AspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74ecb9b2c642a7085cc5adac52e1b82ebee90f45", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c598332ab8aa93b6fec2302831f72f873c15c8e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Equipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn gradient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Jogador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Taila\Downloads\MVC_AspNetCore_ProjetoEPlayers-main\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Início";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"banner\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ecb9b2c642a7085cc5adac52e1b82ebee90f454884", async() => {
                WriteLiteral("INSCREVA SUA EQUIPE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ecb9b2c642a7085cc5adac52e1b82ebee90f456543", async() => {
                WriteLiteral("INSCREVA JOGADORES");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""sobre"">
    <div class=""container"">
        <div>
            <h1>O QUE É MUNDO EM COMUM ?</h1>
            <p> Lorem ipsum dolor sit amet consectetur adipisicing elit. Officiis corporis voluptas odio
                asperiores officia, quisquam eius optio itaque nobis vel. Amet placeat veniam architecto magni
                at facere eaque adipisci laborum. Lorem ipsum dolor sit amet consectetur adipisicing elit. At
                ipsum, veniam ad, illum corrupti nisi fugiat repellat harum aspernatur cupiditate aperiam
                voluptatibus nulla a excepturi facere id non nemo totam! Lorem ipsum dolor sit amet consectetur
                adipisicing elit. Cum numquam expedita architecto quia debitis sint consequatur! Deleniti sed
                itaque illum aut officiis, quasi tempora esse id incidunt consequatur, magni ipsa? Lorem ipsum
                dolor, sit amet consectetur adipisicing elit. Natus, beatae ullam iure blanditiis dolorum illum
                excepturi temp");
            WriteLiteral(@"ore a unde, ipsa facilis aut et tempora nam quaerat nemo saepe, minus eaque. Lorem
                ipsum dolor sit amet consectetur adipisicing elit. Tempore ab recusandae, consectetur dicta
                molestias aliquid eligendi laboriosam sint optio dolor, accusantium quasi eius ad, placeat atque
                harum veniam fuga sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Eveniet </p>
        </div>
    </div>
</div>
<img src=""Images/9a6e4f50b0d94f75ce274348f06a6d56.png"" alt=""Imagem de um  campeão do lol"" class=""champion"">

<section id=""horarios"">

    <div class=""container"">
        <div class=""ao_vivo"">
            <h2>AO VIVO</h2>
            <div class=""partida"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
        </div>

        <div class=""em_breve"">
            <h");
            WriteLiteral(@"2>EM BREVE</h2>
            <div class=""partida"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""partida"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""partida"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
        </div>
    </div>
</section>

<div class=""container content"">
    <section class=""noticias"">
        <div class=""card""");
            WriteLiteral(@">
            <img src=""Images/Teams/T1.jpeg"" alt=""Notícia sobra assunto 1"">
            <div>
            <h4>Título da Noticia</h4>
            <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
                </div>
        </div>


        <div class=""card"">
            <img src=""Images/Teams/T2.jpg"" alt=""Notícia sobra assunto 1"">
            <div>
            <h4>Título da Noticia</h4>
            <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
                </div>
        </div>

        <div class=""card"">
            <img src=""Images/Teams/T3.jpeg"" alt=""Notícia sobra ass");
            WriteLiteral(@"unto 1"">
            <div>
            <h4>Título da Noticia</h4>
            <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
        </div>
        </div>

        <div class=""card"">
            <img src=""Images/Teams/T9.jpeg"" alt=""Notícia sobra assunto 1"">
            <div>
            <h4>Título da Noticia</h4>
            <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
                </div>
        </div>

        <div class=""card"">
            <img src=""Images/Teams/T5.jpeg"" alt=""Notícia sobra assunto 1"">
            <div>
            <h4>Título da Noticia</h4>
          ");
            WriteLiteral(@"  <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
                </div>
        </div>

        <div class=""card"">
            <img src=""Images/Teams/T7.jpeg"" alt=""Notícia sobra assunto 1"">
            <div>
            <h4>Título da Noticia</h4>
            <p> Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quos quibusdam quidem praesentium
                velit vel sapiente nemo obcaecati veritatis dolorum odio facere, quisquam mollitia quo eum.
                Aspernatur quam reiciendis ratione dolorem!</p>
                </div>
        </div>
    </section>
    <section class=""recentes"" id=""resultados"">
        <h3>PARTIDAS RECENTES</h3>

        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" ");
            WriteLiteral(@"alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
   ");
            WriteLiteral(@"         <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</strong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <div class=""resultado"">
            <div class=""team"">
                <strong>SK</st");
            WriteLiteral(@"rong>
                <img src=""Images/SK.png"" alt=""Logo da equipe SK"">
                <I>VS</I>
                <img src=""Images/FLA.png"" alt=""Logo da equipe do Flamengo"">
                <strong>FLA</strong>
            </div>
            <div class=""placar"">
                <P>3 x 2</p>
            </div>
        </div>
        <a href=""todos_os_resultados.html"" class=""btn gradient"">mais resultados</a>
    </section>
</div>");
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