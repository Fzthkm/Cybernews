#pragma checksum "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a7b07ee633bb70ba43dddcf5ead10543853eef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Details), @"mvc.1.0.view", @"/Views/Account/Details.cshtml")]
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
#line 1 "D:\04. Projects\Киберфорум\Views\_ViewImports.cshtml"
using Киберфорум;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\04. Projects\Киберфорум\Views\_ViewImports.cshtml"
using Киберфорум.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\04. Projects\Киберфорум\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a7b07ee633bb70ba43dddcf5ead10543853eef4", @"/Views/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ab566afc0ae2dce96bc3aa073e2f6c548dde2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Киберфорум.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
  
    ViewData["Title"] = "Личный кабинет";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Личный кабинет</h1>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Логин\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
       Write(Html.DisplayFor(model => model._Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Имя\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
       Write(Html.DisplayFor(model => model._Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Тип учётной записи\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
       Write(Html.DisplayFor(model => model.Role.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h1>Список новостей</h1>\r\n");
#nullable restore
#line 33 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
     if (Model.Articles.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Список авторских новостей пусть </span>\r\n");
#nullable restore
#line 36 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }
    else if (Model.Articles.Count <= 10)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Название</h4>\r\n");
#nullable restore
#line 40 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
         for (int i = Model.Articles.Count - 1; i >= 0; i--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl>\r\n                <dd>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef47038", async() => {
#nullable restore
#line 44 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                  Write(Model.Articles[i].Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                    WriteLiteral(Model.Articles[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
#nullable restore
#line 47 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"last10\">\r\n            <h4>Последние 10 новостей</h4>\r\n");
#nullable restore
#line 53 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
             for (int i = Model.Articles.Count - 1; i >= Model.Articles.Count - 10; i--)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dl>\r\n                    <dd>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef410461", async() => {
#nullable restore
#line 57 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                      Write(Model.Articles[i].Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                        WriteLiteral(Model.Articles[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n");
#nullable restore
#line 60 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input class=\"btn btn-outline-dark\" id=\"show\" type=\"button\" value=\"Показать все новости\" />\r\n        </div>\r\n        <div id=\"allArticles\" style=\"display:none\">\r\n            <h4>Список всех новостей</h4>\r\n");
#nullable restore
#line 66 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
             for (int i = Model.Articles.Count - 1; i > 0; i--)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dl>\r\n                    <dd>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef413872", async() => {
#nullable restore
#line 70 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                      Write(Model.Articles[i].Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                        WriteLiteral(Model.Articles[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n");
#nullable restore
#line 73 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <input class=""btn btn-outline-dark"" id=""cancel"" type=""button"" value=""Показать 10 последних"" />
        </div>
        <script>
            var allArticles = document.getElementById(""allArticles"");
            var last10 = document.getElementById(""last10"");
            var cancel = document.getElementById(""cancel"");
            var show = document.getElementById(""show"");
            show.onclick = function () {
                allArticles.style.display = ""block"";
                last10.style.display = ""none"";
            }
            cancel.onclick = function () {
                allArticles.style.display = ""none"";
                last10.style.display = ""block"";
            }
        </script>
");
#nullable restore
#line 90 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    <h1>Список комментариев</h1>\r\n");
#nullable restore
#line 94 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
     if (Model.Comments.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Список комментариев пуст </span>\r\n");
#nullable restore
#line 97 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }
    else if (Model.Comments.Count <= 10)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Последние комментарии</h4>\r\n        <table class=\"table\">\r\n            <tr><td>Статья</td><td>Комментарий</td></tr>\r\n");
#nullable restore
#line 103 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
             for (int i = Model.Comments.Count - 1; i >= 0; i--)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 107 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                   Write(Model.Comments[i].Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 111 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                   Write(Model.Comments[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 114 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 116 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"last10com\">\r\n            <h4>Последние 10 комментариев</h4>\r\n            <table class=\"table\">\r\n                <tr><td>Статья</td><td>Комментарий</td></tr>\r\n");
#nullable restore
#line 123 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                 for (int i = Model.Comments.Count - 1; i >= Model.Comments.Count - 10; i--)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 127 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Comments[i].Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 130 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Comments[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 133 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </table>
            <input class=""btn btn-outline-dark"" id=""showCom"" type=""button"" value=""Показать все комментарии"" />
        </div>
        <div id=""allComments"" style=""display:none"">
            <h4>Список всех комментариев</h4>

            <table class=""table"">
");
#nullable restore
#line 142 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                 for (int i = Model.Comments.Count - 1; i >= 0; i--)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 146 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Comments[i].Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 149 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Comments[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 152 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <input class=\"btn btn-outline-dark\" id=\"cancelCom\" type=\"button\" value=\"Показать 10 последних\" />\r\n        </div>\r\n");
            WriteLiteral(@"        <script>
            var allComments = document.getElementById(""allComments"");
            var last10com = document.getElementById(""last10com"");
            var cancelC = document.getElementById(""cancelCom"");
            var showC = document.getElementById(""showCom"");
            showC.onclick = function () {
                allComments.style.display = ""block"";
                last10com.style.display = ""none"";
            }
            cancelC.onclick = function () {
                allComments.style.display = ""none"";
                last10com.style.display = ""block"";
            }
        </script>
");
#nullable restore
#line 171 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("<div>\r\n    <h1>Список отзывов</h1>\r\n");
#nullable restore
#line 176 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
     if (Model.Reviews.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Список отзывов пуст </span>\r\n");
#nullable restore
#line 179 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }
    else if (Model.Reviews.Count <= 10)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Последние отзывы</h4>\r\n        <table class=\"table\">\r\n            <tr><td>Товар</td><td>Отзыв</td><td>Оценка</td></tr>\r\n");
#nullable restore
#line 185 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
             for (int i = Model.Reviews.Count - 1; i >= 0; i--)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef424515", async() => {
#nullable restore
#line 189 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                           Write(Model.Reviews[i].Stuff._Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                         WriteLiteral(Model.Reviews[i].StuffId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 192 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                   Write(Model.Reviews[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 195 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                   Write(Model.Reviews[i].Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 198 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 200 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"last10com\">\r\n            <h4>Последние 10 отзывов</h4>\r\n            <table class=\"table\">\r\n                <tr><td>Статья</td><td>Комментарий</td></tr>\r\n");
#nullable restore
#line 207 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                 for (int i = Model.Reviews.Count - 1; i >= Model.Reviews.Count - 10; i--)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef428751", async() => {
#nullable restore
#line 211 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                               Write(Model.Reviews[i].Stuff._Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 211 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                             WriteLiteral(Model.Reviews[i].StuffId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 214 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Reviews[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 217 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Reviews[i].Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 220 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </table>
            <input class=""btn btn-outline-dark"" id=""showReview"" type=""button"" value=""Показать все комментарии"" />
        </div>
        <div id=""allReviews"" style=""display:none"">
            <h4>Список всех отзывов</h4>

            <table class=""table"">
");
#nullable restore
#line 229 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                 for (int i = Model.Reviews.Count - 1; i >= 0; i--)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef432922", async() => {
#nullable restore
#line 233 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                                                               Write(Model.Reviews[i].Stuff._Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 233 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                                                                             WriteLiteral(Model.Reviews[i].StuffId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 236 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Reviews[i]._Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 239 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                       Write(Model.Reviews[i].Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 242 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <input class=\"btn btn-outline-dark\" id=\"cancelReview\" type=\"button\" value=\"Показать 10 последних\" />\r\n        </div>\r\n");
            WriteLiteral(@"        <script>
            var allReviews = document.getElementById(""allReviews"");
            var last10r = document.getElementById(""last10r"");
            var cancelReview = document.getElementById(""cancelReview"");
            var showReview = document.getElementById(""showReview"");
            showReview.onclick = function () {
                allReviews.style.display = ""block"";
                last10r.style.display = ""none"";
            }
            cancelReview.onclick = function () {
                allReviews.style.display = ""none"";
                last10r.style.display = ""block"";
            }
        </script>
");
#nullable restore
#line 261 "D:\04. Projects\Киберфорум\Views\Account\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7b07ee633bb70ba43dddcf5ead10543853eef437504", async() => {
                WriteLiteral("\r\n    <i class=\"glyphicon glyphicon-chevron-right\">На главную</i> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Киберфорум.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591