#pragma checksum "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfef753e53b9c0ebc9723ae242acd8f9d1c9818a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_ShowQuestion), @"mvc.1.0.view", @"/Views/Forum/ShowQuestion.cshtml")]
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
#line 1 "E:\DgKala\DgKala\DgKala\Views\_ViewImports.cshtml"
using DgKala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DgKala\DgKala\DgKala\Views\_ViewImports.cshtml"
using DgKala.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
using DgKala.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfef753e53b9c0ebc9723ae242acd8f9d1c9818a", @"/Views/Forum/ShowQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cc2295c22569dc751550200b2a7e730c0e55a3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Forum_ShowQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DgKala.Models.ViewModels.Question.ShowQuestionViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 50px; border-radius: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 40px; border-radius: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectIsTrueAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
  
    ViewData["Title"] =  "???????? ????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .IsTrue {
        border: 2px solid green !important;
    }
</style>
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/""> ???????? ???????? </a></li>
            <li class=""breadcrumb-item""><a href=""/Forum/Questions""> ???????? ?? ???????? </a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ");
#nullable restore
#line 19 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                                               Write(Model.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-8 col-sm-12 col-xs-12"">
            <div class=""inner"">
                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h1>");
#nullable restore
#line 30 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                       Write(Model.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                  \r\n                    <div class=\"panel-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bfef753e53b9c0ebc9723ae242acd8f9d1c9818a7344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1096, "~/UserAvatar/", 1096, 13, true);
#nullable restore
#line 34 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
AddHtmlAttributeValue("", 1109, Model.Question.User.UserAvatar, 1109, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 35 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                   Write(Model.Question.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 35 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                                   Write(Model.Question.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"panel-body\">\r\n                        ");
#nullable restore
#line 38 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                   Write(Html.Raw(Model.Question.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"inner\" style=\"margin-top: 25px;\">\r\n");
#nullable restore
#line 46 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                 foreach (var answer in Model.Answers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"panel\"");
#nullable restore
#line 48 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                  Write((answer.IsTrue)?"IsTrue":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                        <div class=\"panel-heading\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bfef753e53b9c0ebc9723ae242acd8f9d1c9818a10529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1791, "~/UserAvatar/", 1791, 13, true);
#nullable restore
#line 50 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
AddHtmlAttributeValue("", 1804, answer.User.UserAvatar, 1804, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
#nullable restore
#line 51 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                       Write(answer.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 51 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                               Write(answer.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"panel-body\">\r\n                            ");
#nullable restore
#line 54 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                       Write(Html.Raw(answer.BodyAnswer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 56 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                         if (User.Identity.IsAuthenticated && Model.Question.UserId == int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfef753e53b9c0ebc9723ae242acd8f9d1c9818a13396", async() => {
                WriteLiteral("???????? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-questionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                                                                                               WriteLiteral(Model.Question.QuestionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                                                                                                                                                               WriteLiteral(answer.AnswerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["answerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-answerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["answerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n");
#nullable restore
#line 61 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 63 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 66 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""inner"" style=""margin-top: 25px;"">
                    <div class=""panel"">
                        <div class=""panel-heading"">
                            <h1 style=""font-size: 18px;"" class=""text-success text-muted"">???????????? ???????? ????????</h1>
                        </div>
                        <div class=""panel-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfef753e53b9c0ebc9723ae242acd8f9d1c9818a17649", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input type=\"hidden\"name=\"id\"");
                BeginWriteAttribute("value", "value=\"", 3280, "\"", 3313, 1);
#nullable restore
#line 76 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
WriteAttributeValue("", 3287, Model.Question.QuestionId, 3287, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                    <textarea name=""body""></textarea>
                                    <button class=""btn btn-block btn-success"" style=""margin-top: 20px; height: 50px; font-size: 15px;"" type=""submit"">?????? ???????? ??????</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 84 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">????????  ???????? ???????? ???? ?????? ???????? ????????  ?????????? ???????? </div>\r\n");
#nullable restore
#line 88 "E:\DgKala\DgKala\DgKala\Views\Forum\ShowQuestion.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.ckeditor.com/4.15.1/standard/ckeditor.js\"></script>\r\n    <script>\r\n\r\n        CKEDITOR.replace(\'body\', {\r\n            customConfig: \'/js/Config.js\'\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DgKala.Models.ViewModels.Question.ShowQuestionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
