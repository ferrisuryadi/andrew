#pragma checksum "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4011fec32558f9ddad8f065dd20f09d410468708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortOfDestination_Index), @"mvc.1.0.view", @"/Views/PortOfDestination/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PortOfDestination/Index.cshtml", typeof(AspNetCore.Views_PortOfDestination_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4011fec32558f9ddad8f065dd20f09d410468708", @"/Views/PortOfDestination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3707bf8577d6690eda379682e04effd996a011e2", @"/Views/_ViewImports.cshtml")]
    public class Views_PortOfDestination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fms.Models.mtPortOfDestination>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PortOfDestination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
  
    ViewData["Title"] = "Port of Destination";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Header", async() => {
                BeginContext(121, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(127, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dca5bf0beebe42e28900d88b85f74344", async() => {
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
                BeginContext(236, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(241, 175, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <div class=\"box\">\r\n            <div class=\"box-header\">\r\n                <h3 class=\"box-title\">\r\n                    ");
            EndContext();
            BeginContext(416, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb8b171724b44cf81c3060e95b34040", async() => {
                BeginContext(498, 10, true);
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
            BeginContext(512, 306, true);
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
            BeginContext(819, 38, false);
#line 25 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(857, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(897, 44, false);
#line 26 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
            EndContext();
            BeginContext(941, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(981, 45, false);
#line 27 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.countryId));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1066, 52, false);
#line 28 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.countryIdTransit));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1158, 44, false);
#line 29 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1242, 45, false);
#line 30 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1327, 45, false);
#line 31 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1412, 45, false);
#line 32 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1497, 45, false);
#line 33 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 142, true);
            WriteLiteral("</th>\r\n                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 38 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                         foreach (var item in ViewBag.Items)
                        {

#line default
#line hidden
            BeginContext(1773, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1836, 7, false);
#line 41 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1843, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1883, 13, false);
#line 42 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.location);

#line default
#line hidden
            EndContext();
            BeginContext(1896, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                             if (@item.country != null)
                            {

#line default
#line hidden
            BeginContext(1991, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2028, 17, false);
#line 45 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                               Write(item.country.code);

#line default
#line hidden
            EndContext();
            BeginContext(2045, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2148, 49, true);
            WriteLiteral("                                <td>&nbsp;</td>\r\n");
            EndContext();
#line 50 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2228, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 51 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                             if (@item.countryTransit != null)
                            {

#line default
#line hidden
            BeginContext(2323, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2360, 24, false);
#line 53 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                               Write(item.countryTransit.code);

#line default
#line hidden
            EndContext();
            BeginContext(2384, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 54 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2487, 49, true);
            WriteLiteral("                                <td>&nbsp;</td>\r\n");
            EndContext();
#line 58 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2567, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 59 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                             if (@item.isActive)
                            {

#line default
#line hidden
            BeginContext(2648, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2684, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a931ae8209d4a24b8efe4eaeeb8c2af", async() => {
                BeginContext(2792, 4, true);
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
#line 61 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
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
            BeginContext(2800, 103, true);
            WriteLiteral("</td>\r\n                                <!--<td><span class=\"label label-success\">True</span></td> -->\r\n");
            EndContext();
#line 63 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2999, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(3035, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d22e253e85454e8944f015087397d9", async() => {
                BeginContext(3142, 5, true);
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
#line 66 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
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
            BeginContext(3151, 103, true);
            WriteLiteral("</td>\r\n                                <!--<td><span class=\"label label-danger\">False</span></td> -->\r\n");
            EndContext();
#line 68 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3285, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3318, 14, false);
#line 69 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3372, 47, false);
#line 70 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.createdOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3419, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3459, 14, false);
#line 71 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.updatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3473, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3513, 47, false);
#line 72 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(item.updatedOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3560, 466, true);
            WriteLiteral(@"</td>
                            <td>
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                        <span class=""caret""></span>
                                    </button>
                                    <ul class=""dropdown-menu"">
                                        <li>");
            EndContext();
            BeginContext(4026, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede44f8c068b44219532a0c1bc9e1c9d", async() => {
                BeginContext(4106, 4, true);
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
#line 79 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
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
            BeginContext(4114, 51, true);
            WriteLiteral("</li>\r\n                                        <li>");
            EndContext();
            BeginContext(4165, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0615f23dd7d4c20b39ada097a0afabc", async() => {
                BeginContext(4289, 6, true);
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
#line 80 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
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
            BeginContext(4299, 156, true);
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4482, 121, true);
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(4604, 38, false);
#line 89 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(4642, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4682, 44, false);
#line 90 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
            EndContext();
            BeginContext(4726, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4766, 45, false);
#line 91 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.countryId));

#line default
#line hidden
            EndContext();
            BeginContext(4811, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4851, 52, false);
#line 92 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.countryIdTransit));

#line default
#line hidden
            EndContext();
            BeginContext(4903, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4943, 44, false);
#line 93 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(4987, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5027, 45, false);
#line 94 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(5072, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5112, 45, false);
#line 95 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(5157, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5197, 45, false);
#line 96 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(5242, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5282, 45, false);
#line 97 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(5327, 274, true);
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
                BeginContext(5618, 15, true);
                WriteLiteral("\r\n\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5633, "\"", 5725, 1);
#line 112 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
WriteAttributeValue("", 5639, Url.Content("~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"), 5639, 86, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5726, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5749, "\"", 5847, 1);
#line 113 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortOfDestination/Index.cshtml"
WriteAttributeValue("", 5755, Url.Content("~/AdminLTE/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), 5755, 92, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5848, 96, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fms.Models.mtPortOfDestination> Html { get; private set; }
    }
}
#pragma warning restore 1591
