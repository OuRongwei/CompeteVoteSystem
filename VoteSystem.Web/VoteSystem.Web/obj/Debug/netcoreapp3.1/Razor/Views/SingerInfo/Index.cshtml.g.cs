#pragma checksum "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eef64a3641c6ba393892a4afd04b4422ea3c0c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingerInfo_Index), @"mvc.1.0.view", @"/Views/SingerInfo/Index.cshtml")]
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
#line 1 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\_ViewImports.cshtml"
using VoteSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\_ViewImports.cshtml"
using VoteSystem.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eef64a3641c6ba393892a4afd04b4422ea3c0c08", @"/Views/SingerInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883f35d114b19c5cfc7366122ed5c39b44352a24", @"/Views/_ViewImports.cshtml")]
    public class Views_SingerInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<VoteSystem.Model.SingerAndSocreViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef64a3641c6ba393892a4afd04b4422ea3c0c083469", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>菜鸟教程(runoob.com)</title>
    <style>
        .grid-container {
            height: auto;
            width: auto;
            display: grid;
            grid-template-columns: auto auto auto;
            grid-gap: 10px;
            background-color: #2196F3;
            padding: 10px;
        }

            .grid-container > div {
                background-color: rgba(255, 255, 255, 0.8);
                border: 1px solid black;
                text-align: center;
                font-size: 30px;
            }

        img {
            width: 300px;
            height: 300px;
        }

        .grid-container > a {
            color: aqua;
        }
    </style>

    <script>

        function alertInfo() {
            var temp=document.getElementById(""sspan"").innerHTML;
            if (temp==""NoLogin"") {
                alert(""未登录!!!"");
            }
            
    }
    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef64a3641c6ba393892a4afd04b4422ea3c0c085420", async() => {
                WriteLiteral("\r\n    <span id=\"sspan\">\r\n        ");
#nullable restore
#line 48 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
   Write(Html.ValidationMessage("CredentialError", new { style = "color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <script>\r\n            alertInfo();\r\n        </script>\r\n    </span>\r\n    <input type=\"text\" placeholder=\"请输入歌手号数或歌手姓名\" /><input type=\"button\" value=\"查询\" />\r\n    <div class=\"grid-container\">\r\n");
#nullable restore
#line 55 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
         foreach (var singer in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n\r\n");
#nullable restore
#line 59 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
                 if (!string.IsNullOrEmpty(singer.ImageUrl))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <img");
                BeginWriteAttribute("src", " src=\"", 1569, "\"", 1613, 2);
                WriteAttributeValue("", 1575, "http://localhost:8080/", 1575, 22, true);
#nullable restore
#line 61 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
WriteAttributeValue("", 1597, singer.ImageUrl, 1597, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 62 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 63 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
              Write(singer.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 号 ");
#nullable restore
#line 63 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
                           Write(singer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>票数：");
#nullable restore
#line 64 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
                 Write(singer.PiaoShu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef64a3641c6ba393892a4afd04b4422ea3c0c088285", async() => {
                    WriteLiteral("投票");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1758, "~/UserVote/Index/", 1758, 17, true);
#nullable restore
#line 66 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
AddHtmlAttributeValue("", 1775, singer.Id, 1775, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eef64a3641c6ba393892a4afd04b4422ea3c0c089900", async() => {
                    WriteLiteral("详情");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1820, "~/SingerInfo/SingerDetails/", 1820, 27, true);
#nullable restore
#line 67 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"
AddHtmlAttributeValue("", 1847, singer.Id, 1847, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 69 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\SingerInfo\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <p>网格容器的所有直系子元素将成为网格元素。</p>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<VoteSystem.Model.SingerAndSocreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
