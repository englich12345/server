#pragma checksum "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692fe598774a53dc74de0f6589e588e14607f5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreApp;

#line default
#line hidden
#line 2 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreApp.Data.Entities;

#line default
#line hidden
#line 3 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreApp.Models;

#line default
#line hidden
#line 4 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreApp.Application.ViewModels.Functions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692fe598774a53dc74de0f6589e588e14607f5ec", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8128b06869301f80f771fab408939ed6eb514e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/product/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "40", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(60, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(67, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692fe598774a53dc74de0f6589e588e14607f5ec5933", async() => {
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
                EndContext();
                BeginContext(125, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(130, 3008, true);
            WriteLiteral(@"<div class=""page-title"">
    <div class=""title_left"">
        <h3>Products <small>List products</small></h3>
    </div>

    <div class=""title_right"">
        <div class=""col-md-3 col-sm-5 col-xs-12 form-group pull-right top_search"">
            <div class=""input-group"">
                <input type=""text"" id=""txtsearchkeyword"" class=""form-control"" placeholder=""Search for..."">
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"" id=""search"" type=""button"">Go!</button>
                </span>
            </div>
        </div>
        <div class=""col-md-3 col-sm-5 col-xs-12 form-group pull-right"">

        </div>
        <div class=""col-md-6 col-sm-5 col-xs-12 form-group pull-right"">
            <button id=""btnCreate"" class=""btn btn-success"">Create</button>
        </div>
    </div>
</div>

<div class=""clearfix""></div>

<div class=""row"">
    <div class=""col-md-12 col-sm-12 col-xs-12"">
        <div class=""x_panel"">
            <div class=""x_");
            WriteLiteral(@"title"">
                <h2>List products</h2>
                <ul class=""nav navbar-right panel_toolbox"">
                    <li>
                        <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                    </li>
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                        <ul class=""dropdown-menu"" role=""menu"">
                            <li>
                                <a href=""#"">Settings 1</a>
                            </li>
                            <li>
                                <a href=""#"">Settings 2</a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a class=""close-link""><i class=""fa fa-close""></i></a>
                    </li>
                </ul>
                <div class=""clearfix""></div");
            WriteLiteral(@">
            </div>
            <div class=""x_content"">

                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th width=""10%"">#</th>
                            <th>Name</th>
                            <th>Category</th>
                            <th>Price</th>
                            <th>Image</th>
                            <th>Created Date</th>
                            <th>Status</th>
                        </tr>
                    </thead>
                    <tbody id=""tbl-content""></tbody>
                </table>
                <!--Pagination-->
                <div class=""row"">
                    <div class=""col-sm-5"">
                        <div class=""dataTables_info"" id=""datatable-checkbox_info"" role=""status"" aria-live=""polite"">
                            <select id=""ddlShowPage"">
                                ");
            EndContext();
            BeginContext(3138, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692fe598774a53dc74de0f6589e588e14607f5ec10481", async() => {
                BeginContext(3177, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3188, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3222, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692fe598774a53dc74de0f6589e588e14607f5ec11970", async() => {
                BeginContext(3241, 2, true);
                WriteLiteral("20");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3252, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3286, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692fe598774a53dc74de0f6589e588e14607f5ec13376", async() => {
                BeginContext(3305, 2, true);
                WriteLiteral("30");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3316, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3350, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692fe598774a53dc74de0f6589e588e14607f5ec14782", async() => {
                BeginContext(3369, 2, true);
                WriteLiteral("40");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3380, 747, true);
            WriteLiteral(@"
                            </select>
                            <span class=""item-per-page"">
                                Record/Page.
                            </span>
                            Total records: <strong id=""lblTotalRecords""></strong>
                        </div>
                    </div><div class=""col-sm-7"">
                        <div class=""dataTables_paginate paging_simple_numbers"" id=""datatable-checkbox_paginate"">
                            <ul id=""paginationUL""></ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <th scope=""row"">
");
            EndContext();
            BeginContext(4309, 565, true);
            WriteLiteral(@"            <a class=""btn btn-default btn-sm btn-edit"" data-id=""{{Id}}""><i class=""fa fa-pencil""></i></a>
            <a class=""btn btn-danger btn-sm btn-delete"" data-id=""{{Id}}""><i class=""fa fa-trash""></i></a>
        </th>
        <td>{{Name}}</td>
        <td>{{CategoryName}}</td>
        <td>{{Price}}</td>
        <td>{{{Image}}}</td>
        <td>{{CreatedDate}}</td>
        <td>{{{Status}}}</td>
    </tr>
</script>
<script id=""category-template"" type=""x-tmpl-mustache"">
     <option value=""{{Id}}"" {{Selected}}>{{Category}}</option>
</script>
");
            EndContext();
            BeginContext(4875, 36, false);
#line 119 "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\Product\Index.cshtml"
Write(Html.Partial("_AddEditModel.cshtml"));

#line default
#line hidden
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