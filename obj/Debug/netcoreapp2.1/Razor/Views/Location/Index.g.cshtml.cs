#pragma checksum "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d474ccdf4d9f09af5e09d7fd7d5825951a7e1a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/Index.cshtml", typeof(AspNetCore.Views_Location_Index))]
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
#line 1 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/_ViewImports.cshtml"
using fms;

#line default
#line hidden
#line 2 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/_ViewImports.cshtml"
using fms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d474ccdf4d9f09af5e09d7fd7d5825951a7e1a71", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3707bf8577d6690eda379682e04effd996a011e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fms.Models.mtLocation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Location", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "isActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
  
    ViewData["Title"] = "Location";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Header", async() => {
                BeginContext(101, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(107, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1635d6cd975f488aa81366fb00ed9bb2", async() => {
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
                BeginContext(216, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(221, 175, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <div class=\"box\">\r\n            <div class=\"box-header\">\r\n                <h3 class=\"box-title\">\r\n                    ");
            EndContext();
            BeginContext(396, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aab2d9304bee4b25950dc307ef59d682", async() => {
                BeginContext(469, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 306, true);
            WriteLiteral(@"
                </h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body table-responsive"">
                <table id=""example1"" class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(790, 38, false);
#line 25 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(828, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(868, 44, false);
#line 26 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
            EndContext();
            BeginContext(912, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(952, 44, false);
#line 27 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(996, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1036, 45, false);
#line 28 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1121, 45, false);
#line 29 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1206, 45, false);
#line 30 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1291, 45, false);
#line 31 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 142, true);
            WriteLiteral("</th>\r\n                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                         foreach (var item in ViewBag.Items)
                        {

#line default
#line hidden
            BeginContext(1567, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1638, 7, false);
#line 39 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1689, 13, false);
#line 40 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.location);

#line default
#line hidden
            EndContext();
            BeginContext(1702, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                 if (@item.isActive)
                                {

#line default
#line hidden
            BeginContext(1798, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(1838, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52389154bc964f0799b5b9d8d0f52cd0", async() => {
                BeginContext(1937, 4, true);
                WriteLiteral("True");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                                                                                                     WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1945, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-success\">True</span></td> -->\r\n");
            EndContext();
#line 45 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2160, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2200, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d345f32df17d46a28cb4e667c93ea5c3", async() => {
                BeginContext(2298, 5, true);
                WriteLiteral("False");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                                                                                                    WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2307, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-danger\">False</span></td> -->\r\n");
            EndContext();
#line 50 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2449, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2486, 14, false);
#line 51 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(2500, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2544, 47, false);
#line 52 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.createdOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2591, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2635, 14, false);
#line 53 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.updatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2693, 47, false);
#line 54 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.updatedOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2740, 494, true);
            WriteLiteral(@"</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                            <span class=""caret""></span>
                                        </button>
                                        <ul class=""dropdown-menu"">
                                            <li>");
            EndContext();
            BeginContext(3234, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92fa5cbddb224173b9bb7ffc7de7551c", async() => {
                BeginContext(3305, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                                                                                 WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3313, 55, true);
            WriteLiteral("</li>\r\n                                            <li>");
            EndContext();
            BeginContext(3368, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee43b598102b4f95915909e159fe09be", async() => {
                BeginContext(3483, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                                                                                   WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3493, 172, true);
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 67 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3692, 121, true);
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(3814, 38, false);
#line 71 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(3852, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3892, 44, false);
#line 72 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
            EndContext();
            BeginContext(3936, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3976, 44, false);
#line 73 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(4020, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4060, 45, false);
#line 74 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(4105, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4145, 45, false);
#line 75 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(4190, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4230, 45, false);
#line 76 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(4275, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4315, 45, false);
#line 77 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4360, 274, true);
            WriteLiteral(@"</th>
                            <th>Action</th>
                        </tr>
                    </tfoot>
                </table>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4651, 15, true);
                WriteLiteral("\r\n\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4666, "\"", 4758, 1);
#line 92 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
WriteAttributeValue("", 4672, Url.Content("~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"), 4672, 86, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4759, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4782, "\"", 4880, 1);
#line 93 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
WriteAttributeValue("", 4788, Url.Content("~/AdminLTE/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), 4788, 92, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4881, 96, true);
                WriteLiteral("></script>\r\n    <script>\r\n$(function () {\r\n    $(\'#example1\').DataTable()\r\n  })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fms.Models.mtLocation> Html { get; private set; }
    }
}
#pragma warning restore 1591
