#pragma checksum "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0314e97bdd11c71be0fca3454df49b267a7e8e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0314e97bdd11c71be0fca3454df49b267a7e8e", @"/Views/Location/Index.cshtml")]
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96042ccb3a724e90811b483393afb45e", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "188dd47494e3491e940b16bbf6e16e58", async() => {
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
            BeginContext(1689, 9, false);
#line 40 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                 if (@item.isActive)
                                {

#line default
#line hidden
            BeginContext(1794, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(1834, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9dab68035441fba1ca938c28e83693", async() => {
                BeginContext(1933, 4, true);
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
            BeginContext(1941, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-success\">True</span></td> -->\r\n");
            EndContext();
#line 45 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2156, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2196, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61b48f008bd44116b63dbf420d61fa81", async() => {
                BeginContext(2294, 5, true);
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
            BeginContext(2303, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-danger\">False</span></td> -->\r\n");
            EndContext();
#line 50 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2445, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2482, 14, false);
#line 51 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(2496, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2540, 47, false);
#line 52 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.createdOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2631, 14, false);
#line 53 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.updatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2645, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2689, 47, false);
#line 54 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                               Write(item.updatedOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2736, 494, true);
            WriteLiteral(@"</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                            <span class=""caret""></span>
                                        </button>
                                        <ul class=""dropdown-menu"">
                                            <li>");
            EndContext();
            BeginContext(3230, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c7172c01024b8daf306d5cde1880c3", async() => {
                BeginContext(3301, 4, true);
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
            BeginContext(3309, 55, true);
            WriteLiteral("</li>\r\n                                            <li>");
            EndContext();
            BeginContext(3364, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16357c42794a40e8ad505465293ce579", async() => {
                BeginContext(3479, 6, true);
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
            BeginContext(3489, 172, true);
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 67 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3688, 121, true);
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(3810, 38, false);
#line 71 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(3848, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3888, 44, false);
#line 72 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
            EndContext();
            BeginContext(3932, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3972, 44, false);
#line 73 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(4016, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4056, 45, false);
#line 74 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(4101, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4141, 45, false);
#line 75 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(4186, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4226, 45, false);
#line 76 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(4271, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4311, 45, false);
#line 77 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4356, 274, true);
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
                BeginContext(4647, 15, true);
                WriteLiteral("\r\n\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4662, "\"", 4754, 1);
#line 92 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
WriteAttributeValue("", 4668, Url.Content("~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"), 4668, 86, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4755, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4778, "\"", 4876, 1);
#line 93 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Location/Index.cshtml"
WriteAttributeValue("", 4784, Url.Content("~/AdminLTE/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), 4784, 92, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4877, 96, true);
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
