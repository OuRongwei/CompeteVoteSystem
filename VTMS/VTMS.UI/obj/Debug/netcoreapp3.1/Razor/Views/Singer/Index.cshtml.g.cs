#pragma checksum "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06129c8c7e1cd161858aa4b3ec16893a8a59920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Singer_Index), @"mvc.1.0.view", @"/Views/Singer/Index.cshtml")]
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
#line 1 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\_ViewImports.cshtml"
using VTMS.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\_ViewImports.cshtml"
using VTMS.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06129c8c7e1cd161858aa4b3ec16893a8a59920", @"/Views/Singer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa30c8a1142de86ad9b76c1b04a4a432b26d7f5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Singer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<VTMS.Models.Singer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Singer/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style type=""text/css"">
    .tbl {
    }

        .tbl a {
            color: red
        }

    table {
        border-collapse: collapse;
    }

    input {
        border: 0;
        outline: none;
    }
</style>

<h1>
    歌手管理页面
</h1>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06129c8c7e1cd161858aa4b3ec16893a8a599203670", async() => {
                WriteLiteral("\r\n    <input type=\"button\" value=\"新增歌手\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""tbl"" border=""1"">
    <tr>
        <th>Id</th>
        <th>歌手照片</th>
        <th>歌手头衔</th>
        <th>歌手名字</th>
        <th>歌手年龄</th>
        <th>婚姻状况</th>
        <th>歌手简介</th>
        <th>修改</th>
        <th>删除</th>
    </tr>
");
#nullable restore
#line 39 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
     foreach (var singer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 42 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 739, "\"", 783, 2);
            WriteAttributeValue("", 745, "http://localhost:8080/", 745, 22, true);
#nullable restore
#line 43 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
WriteAttributeValue("", 767, singer.ImageUrl, 767, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;height:100px;\" /></td>\r\n            <td>");
#nullable restore
#line 44 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Marry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
           Write(singer.Brief);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06129c8c7e1cd161858aa4b3ec16893a8a599207170", async() => {
                WriteLiteral("修改");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1030, "~/Singer/Edit/", 1030, 14, true);
#nullable restore
#line 49 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
AddHtmlAttributeValue("", 1044, singer.Id, 1044, 10, false);

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
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06129c8c7e1cd161858aa4b3ec16893a8a599208698", async() => {
                WriteLiteral("删除");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1094, "~/Singer/Remove/", 1094, 16, true);
#nullable restore
#line 50 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
AddHtmlAttributeValue("", 1110, singer.Id, 1110, 10, false);

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
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "F:\C#\2022第一学期实训\Test\VTMS\VTMS.UI\Views\Singer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<VTMS.Models.Singer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
