#pragma checksum "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/CostShipping/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924653d4a9447a4785202b7f29586b4b68021cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CostShipping_Index), @"mvc.1.0.view", @"/Views/CostShipping/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CostShipping/Index.cshtml", typeof(AspNetCore.Views_CostShipping_Index))]
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
#line 1 "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/_ViewImports.cshtml"
using fms;

#line default
#line hidden
#line 2 "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/_ViewImports.cshtml"
using fms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"924653d4a9447a4785202b7f29586b4b68021cd9", @"/Views/CostShipping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3707bf8577d6690eda379682e04effd996a011e2", @"/Views/_ViewImports.cshtml")]
    public class Views_CostShipping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fms.Models.trCostShipping>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/datatables.net/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/datatables.net/css/rowDetails.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/CostShipping/Index.cshtml"
  
    ViewData["Title"] = "Cost Shipping";

#line default
#line hidden
            DefineSection("Header", async() => {
                BeginContext(102, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(108, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "760411143b104a7b859a623a716de75c", async() => {
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
                EndContext();
                BeginContext(211, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(217, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d2531ef9a924235884bdccf6048c82c", async() => {
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
                EndContext();
                BeginContext(324, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(329, 928, true);
            WriteLiteral(@"
<div id=""errorMessageHeader"">
</div>

<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
            <div class=""box-body table-responsive"">
                <table id=""indexTable"" class=""table table-bordered table-striped"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>Id</th>
                            <th>Code</th>
                            <th>Name</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
            <!-- /.box-body -->
            <div class=""overlay"" id=""refreshLoad"">
                <i class=""fa fa-refresh fa-spin""></i>
            </div>
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1274, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1287, "\"", 1352, 1);
#line 41 "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/CostShipping/Index.cshtml"
WriteAttributeValue("", 1293, Url.Content("https://code.jquery.com/jquery-2.2.4.min.js"), 1293, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1353, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1376, "\"", 1468, 1);
#line 42 "/Users/ferrisuryadi/Documents/GitHub/andrew/Views/CostShipping/Index.cshtml"
WriteAttributeValue("", 1382, Url.Content("~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"), 1382, 86, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1469, 6992, true);
                WriteLiteral(@"></script>

    <script>
        $(document).ready(function(){
            var table = $('#indexTable').DataTable( {
                ""columns"": [
                    {
                        ""className"": 'details-control',
                        ""orderable"": false,
                        ""data"": null,
                        ""defaultContent"": ''
                    },
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [1],
                        ""defaultContent"": ''
                    },
                    {
                        ""targets"": [2],
                        ""defaultContent"": ''
                    },
                    {
                        ""targets"": [3],
                        ""data"": null,
                        ""defaultContent"": ""<input type='button' href='#' style='width: 80px");
                WriteLiteral(@"; height: 5spx;' value='New' class='newTransaction btn btn-primary' />""
                    },
                ],
                ""autoWidth"": false
            } );

            // Add event listener for opening and closing details
            $('#indexTable tbody').on('click', 'td.details-control', function () {
                var tr = $(this).closest('tr');
                var row = table.row( tr );

                if (row.child.isShown()) {
                    // This row is already open - close it
                    row.child.hide();
                    tr.removeClass('shown');
                }
                else {
                    // Open this row
                    row.child( showDetail(row.data()) ).show();
                    tr.addClass('shown');
                }
            } );

            loadVendor();
            $('#refreshLoad').remove();
        });

        function loadVendor() {
            $('#indexTable').DataTable().clear().draw();
            $(");
                WriteLiteral(@"'#divError').remove();

            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'GET',
                url: ""/CostShipping/loadVendor"",
                success: function (result) {
                    switch (result.status) {
                        case 200:
                            //load vendor
                            for (var i=0; i < result.message.length; i++) {
                                $('#indexTable').DataTable().row.add([
                                    '',
                                    result.message[i].id,
                                    result.message[i].code,
                                    result.message[i].name
                                 ]).draw(false);
                            }
                            break;
                    }
                },
                error: function (result) {
                    var element = document.getElemen");
                WriteLiteral(@"tById(""errorMessageHeader"");
                    var error = '<li>Error! Check Console</li>';
                    var alert = '<div class=""alert alert-danger alert-dismissible"" id = ""divError""> <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button><h4><i class=""icon fa fa-ban""></i> Error!</h4><div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>' + error + '</ul></div></div>';

                    element.innerHTML = alert;
                    console.log(result);
                }
            });
        }

        $(document).on('click', '.newTransaction', function (e) {
            e.preventDefault();

            var data = $('#indexTable').DataTable().row($(this).parents('tr')).data();
            var id = data[1];

            window.location.href = '/CostShipping/Add/' + id;
        });

        function showDetail (data) {
            var id = data[1];
            var div = $('<div/>').addClass('loading').text('Loading...');

    ");
                WriteLiteral(@"        var result = '';

            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'GET',
                url: ""/CostShipping/loadTransaction/"" + id,
                success: function (result) {
                    switch (result.status) {
                        case 200:
                            var txData = result.message;
                            var length = result.message.length;

                            result = '<table id=""detailTable"" class=""table table-bordered table-striped"" style=""width:100%"">';
                            result = result + '<thead><tr><th>Ref No</th><th>Date</th><th>Valid Date</th><th>Updated By</th><th>Updated On</th><th>Action</th></tr></thead>';
                            result = result + '<tbody>';

                            for (var i=0; i < length; i++) {
                                result = result + '<tr>';
                                result = result");
                WriteLiteral(@" + '<td>' + txData[i].referenceNo + '</td>';
                                result = result + '<td>' + txData[i].txDate + '</td>';
                                result = result + '<td>' + txData[i].txValidDate + '</td>';
                                result = result + '<td>' + txData[i].updatedBy + '</td>';
                                result = result + '<td>' + txData[i].updatedOn + '</td>';
                                result = result + '<td><input type=""button"" data-itemId=""' + txData[i].id.toString() + '"" href=""#"" style=""width: 80px"" value=""View"" class=""viewTransaction btn btn-info"" /></td>';
                                result = result + '</tr>';
                            }
                            result = result + '</tbody></table>';

                            div.html(result).removeClass('loading');
                            break;
                    }
                },
                error: function (result) {
                    var element = document.getElem");
                WriteLiteral(@"entById(""errorMessageHeader"");
                    var error = '<li>Error! Check Console</li>';
                    var alert = '<div class=""alert alert-danger alert-dismissible"" id = ""divError""> <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button><h4><i class=""icon fa fa-ban""></i> Error!</h4><div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>' + error + '</ul></div></div>';

                    element.innerHTML = alert;
                    console.log(result);
                }
            });

            return div;
        }

        $(document).on('click', '.viewTransaction', function (e) {
            e.preventDefault();

            var id = $(this).attr('data-itemId');
            window.location.href = '/CostShipping/Edit/' + id;
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fms.Models.trCostShipping> Html { get; private set; }
    }
}
#pragma warning restore 1591
