#pragma checksum "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6712a3ffce30428e3dc641550131af07853a9b23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lancamento_Index), @"mvc.1.0.view", @"/Views/Lancamento/Index.cshtml")]
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
#line 11 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\_ViewImports.cshtml"
using FinanCWebMaster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6712a3ffce30428e3dc641550131af07853a9b23", @"/Views/Lancamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84a2df0dbc42a5518a850d92022068b58cc5313", @"/Views/_ViewImports.cshtml")]
    public class Views_Lancamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lancamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lancamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1> - Lançamentos - </h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6712a3ffce30428e3dc641550131af07853a9b235574", async() => {
                WriteLiteral(" Click here to create a new lançamento ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <table class=""table table-dark"">

        <thead>

            <tr>

                <th scope=""col""> ID </th>
                <th scope=""col""> Nome da categoria </th>
                <th scope=""col""> Conta </th>
                <th scope=""col""> Descricao </th>
                <th scope=""col""> Valor </th>
                <th scope=""col""> Creation date </th>

                <th scope=""col""></th>

            </tr>

        </thead>

        <!-- LISTING ALL ACCOUNTS -->
        <tbody>

");
#nullable restore
#line 37 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
             foreach (Lancamento lancamento in Model)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                 if (lancamento.isProfit)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <th>");
#nullable restore
#line 45 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 47 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 49 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Conta.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 51 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 53 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 55 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6712a3ffce30428e3dc641550131af07853a9b2310062", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                                                                                 WriteLiteral(lancamento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6712a3ffce30428e3dc641550131af07853a9b2312598", async() => {
                WriteLiteral(" Update ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                                                                                 WriteLiteral(lancamento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </th>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"

                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-danger\">\r\n\r\n                        <th>");
#nullable restore
#line 72 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 74 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 76 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Conta.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 78 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 80 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>");
#nullable restore
#line 82 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                       Write(lancamento.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6712a3ffce30428e3dc641550131af07853a9b2317402", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                                                                                 WriteLiteral(lancamento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6712a3ffce30428e3dc641550131af07853a9b2319938", async() => {
                WriteLiteral(" Update ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                                                                                 WriteLiteral(lancamento.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </th>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 92 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\FOX\Desktop\FinanCWebMaster\FinanCWebMaster\FinanCWebMaster\Views\Lancamento\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lancamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
