#pragma checksum "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f04117a4a02507e4491535a4f3996335a5a1635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompeteInfo_CompeteInfoPage), @"mvc.1.0.view", @"/Views/CompeteInfo/CompeteInfoPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f04117a4a02507e4491535a4f3996335a5a1635", @"/Views/CompeteInfo/CompeteInfoPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883f35d114b19c5cfc7366122ed5c39b44352a24", @"/Views/_ViewImports.cshtml")]
    public class Views_CompeteInfo_CompeteInfoPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VoteSystem.Model.Compete>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #examplel {
        border: 2px solid #0094ff;
        padding: 10px 40px;
        background: #f5e1e1;
        width: 1000px;
        height: 500px;
        border-radius: 25px;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    }

    .matchul {
        display: flex;
        justify-content: space-between;
        bottom: 0px;
        margin:40px auto auto;
    }

        .matchul li {
            width: 200px;
            height: 50px;
            list-style: none;
        }
    p {
        text-indent: 2em;
        margin:30px auto auto;
    }
    h1{
        text-align:center;
    }
</style>

<div>
    <h1 class=""display-4"">欢迎来到好声音歌唱比赛投票系统</h1>

    <div id=""examplel"">
        <h1>比赛主题：");
#nullable restore
#line 41 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>\r\n            比赛简介：");
#nullable restore
#line 43 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml"
            Write(Model.Brief);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <ul class=\"matchul\">\r\n            <li>比赛开始时间：");
#nullable restore
#line 46 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml"
                  Write(Model.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>比赛结束时间：");
#nullable restore
#line 47 "F:\C#\2022第一学期实训\Test\VoteSystem.Web\VoteSystem.Web\Views\CompeteInfo\CompeteInfoPage.cshtml"
                  Write(Model.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VoteSystem.Model.Compete> Html { get; private set; }
    }
}
#pragma warning restore 1591