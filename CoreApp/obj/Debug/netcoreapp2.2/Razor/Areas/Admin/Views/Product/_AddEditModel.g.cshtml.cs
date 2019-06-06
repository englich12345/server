#pragma checksum "F:\NET project\lich-server\CoreApp\Areas\Admin\Views\Product\_AddEditModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7961d6572efd17f8cb2250822ccba3625a6a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__AddEditModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_AddEditModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/_AddEditModel.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product__AddEditModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7961d6572efd17f8cb2250822ccba3625a6a81", @"/Areas/Admin/Views/Product/_AddEditModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8128b06869301f80f771fab408939ed6eb514e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__AddEditModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 581, true);
            WriteLiteral(@"<div id=""modal-add-edit"" class=""bootbox modal fade modal-darkorange in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""bootbox-close-button close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Add edit product</h4>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            EndContext();
            BeginContext(581, 7613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7961d6572efd17f8cb2250822ccba3625a6a815423", async() => {
                BeginContext(644, 669, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidIdM"" value=""0"" />
                            <label for=""txtNameM"" class=""col-sm-2 control-label no-padding-right"">Name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtNameM"" class=""form-control"" id=""txtNameM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label no-padding-right"">Category</label>
                            <div class=""col-sm-10"" >
");
                EndContext();
                BeginContext(1439, 6748, true);
                WriteLiteral(@"                                <select id=""ddlCategoryIdM"">

                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtDescM"" class=""col-sm-2 control-label no-padding-right"">Description</label>
                            <div class=""col-sm-10"">
                                <textarea rows=""4"" name=""txtDescM"" class=""form-control"" id=""txtDescM""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtUnitM"" class=""col-sm-2 control-label no-padding-right"">Unit</label>
                            <div class=""col-sm-5"">
                                <input type=""text"" name=""txtUnitM"" class=""form-control"" id=""txtUnitM"">
                            </div>
                        </div>
                        <div class=""form-group"">
        ");
                WriteLiteral(@"                    <label class=""col-sm-2 control-label "">Sell price</label>
                            <div class=""col-sm-2"">
                                <input type=""text"" name=""txtPriceM"" class=""form-control"" id=""txtPriceM"">
                            </div>

                            <label class=""col-sm-2 control-label"">Original price</label>
                            <div class=""col-sm-2"">
                                <input type=""text"" name=""txtOriginalPriceM"" class=""form-control"" id=""txtOriginalPriceM"">
                            </div>
                            <label class=""col-sm-2 control-label"">Promotion</label>
                            <div class=""col-sm-2"">
                                <input type=""text"" name=""txtPromotionPriceM"" class=""form-control"" id=""txtPromotionPriceM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtImageM"" class=""col-sm-2 con");
                WriteLiteral(@"trol-label no-padding-right"">Image</label>
                            <div class=""col-sm-6"">
                                <div class=""input-group"">
                                    <input type=""text"" name=""txtImage"" class=""form-control"" id=""txtImage"" />
                                    <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                                    <span class=""input-group-btn"">
                                        <input type=""button"" id=""btnSelectImg"" class=""btn btn-default"" value=""Browser"" />
                                    </span>
                                </div>

                            </div>

                        </div>
                        <div class=""form-group"">
                            <label for=""txtContentM"" class=""col-sm-2 control-label no-padding-right"">Content</label>
                            <div class=""col-sm-10"">
                                <textarea id=""txtContent"" rows=""6"" class=""form-control""></");
                WriteLiteral(@"textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtMetakeywordM"" class=""col-sm-2 control-label no-padding-right"">SEO title</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtSeoPageTitleM"" class=""form-control"" id=""txtSeoPageTitleM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoAliasM"" class=""col-sm-2 control-label no-padding-right"">SEO Url</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtSeoAliasM"" class=""form-control"" id=""txtSeoAliasM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtMetakeywordM"" class=""col-sm-2 contr");
                WriteLiteral(@"ol-label no-padding-right"">SEO Keywords</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtMetakeywordM"" class=""form-control"" id=""txtMetakeywordM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtMetaDescriptionM"" class=""col-sm-2 control-label no-padding-right"">SEO Description</label>
                            <div class=""col-sm-10"">
                                <textarea rows=""3"" name=""txtMetaDescriptionM"" class=""form-control"" id=""txtMetaDescriptionM""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtTagM"" class=""col-sm-2 control-label no-padding-right"">Tag (separated by comma)</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txt");
                WriteLiteral(@"TagM"" class=""form-control"" id=""txtTagM"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatusM"">
                                        <span class=""text"">Active.</span>
                                    </label>
                                    <label>
                                        <input type=""checkbox"" id=""ckHotM"">
                                        <span class=""text"">Hot product</span>
                                    </label>

                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckShowHomeM"">
                                        <span class=""text"">Show on home</span>
 ");
                WriteLiteral(@"                                   </label>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save changes</button>
                                <button type=""button"" id=""btnCancel"" data-dismiss=""modal"" class=""btn btn-danger"">Cancel</button>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(8194, 82, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
