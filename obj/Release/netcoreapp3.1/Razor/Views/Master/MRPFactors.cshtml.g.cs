#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c33d51033a1a64fbd0e086fe8bed6368f37b15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_MRPFactors), @"mvc.1.0.view", @"/Views/Master/MRPFactors.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c33d51033a1a64fbd0e086fe8bed6368f37b15", @"/Views/Master/MRPFactors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_MRPFactors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.Repositories.Entity.MRPFactor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EmpireHome/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/MRPFactorData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
  
    int rCnt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""row"">
            <div class=""col-md-11"">
                <div class=""header-icon"">
                    <i class=""fa fa-dashboard""></i>
                </div>
                <div class=""header-title"">
                    <h1>MRP Factors</h1>
                    <small>Master Data management.</small>
                </div>
            </div>
        <div class=""btn-group float-right"" role=""group"">
            <div class=""buttonexport"" id=""buttonlist"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c33d51033a1a64fbd0e086fe8bed6368f37b155000", async() => {
                WriteLiteral("\r\n                    <i class=\"fa fa-reply mr-2\"></i> Back\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
</div>
    </section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-lg-12 pinpin"">
            <div class=""card"" data-sortable=""true"">
                <div class=""card-header"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""card-title custom_title"">
                                <h4>MRP Factors</h4>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""btn-group float-right"" role=""group"">
                                <div class=""buttonexport"" id=""buttonlist"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c33d51033a1a64fbd0e086fe8bed6368f37b157045", async() => {
                WriteLiteral("\r\n                                        <i class=\"fa fa-plus\"></i> Add New\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                    <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                    <div class=""table-responsive"">
                        <table id=""mydatatable"" class=""table table-bordered table-striped table-hover"">
                            <thead class=""back_table_color"">
                                <tr class=""info"">
                                    <th>#.</th>
                                    <th>Factor Name</th>
                                    <th>Factor Value</th>

                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 68 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
                                 foreach (var u in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 71 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
                                        Write(rCnt ++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 72 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
                                       Write(u.FactorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                        <td>");
#nullable restore
#line 75 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
                                       Write(u.FactorValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c33d51033a1a64fbd0e086fe8bed6368f37b1510600", async() => {
                WriteLiteral(@"
                                                <button type=""button"" class=""btn btn-add btn-sm"">
                                                    <i class=""fa fa-pencil""></i>
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3311, "~/Master/MRPFactorData?id=", 3311, 26, true);
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
AddHtmlAttributeValue("", 3337, u.TRId, 3337, 7, false);

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
            WriteLiteral("\r\n                                            <a href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3711, "\"", 3740, 3);
            WriteAttributeValue("", 3721, "ShowDelete(", 3721, 11, true);
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
WriteAttributeValue("", 3732, u.TRId, 3732, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3739, ")", 3739, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </button>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 90 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\MRPFactors.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- /.content -->
</div>
<script>
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {
                $.ajax({
                    url: GlobalUrl + ""Master/DeleteMRPFactor?id="" + id,
                    type: 'post',
                    data: '{}',
                    success: function (result) {
                        toastr[""success""](""Successuflly deleted!"");
                        window.location.href = window.location.href;
                    }
                });
            }");
            WriteLiteral("\r\n            else {\r\n                toastr[\"error\"](\"Delete cancelled!\")\r\n            }\r\n            return false;\r\n        });\r\n\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.Repositories.Entity.MRPFactor>> Html { get; private set; }
    }
}
#pragma warning restore 1591