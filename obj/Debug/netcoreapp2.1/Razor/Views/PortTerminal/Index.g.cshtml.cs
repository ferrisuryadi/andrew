#pragma checksum "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf0be14ee65645fa93da064efdb9da36605c7df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortTerminal_Index), @"mvc.1.0.view", @"/Views/PortTerminal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PortTerminal/Index.cshtml", typeof(AspNetCore.Views_PortTerminal_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf0be14ee65645fa93da064efdb9da36605c7df", @"/Views/PortTerminal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3707bf8577d6690eda379682e04effd996a011e2", @"/Views/_ViewImports.cshtml")]
    public class Views_PortTerminal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fms.Models.mtPortTerminal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PortTerminal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
  
    ViewData["Title"] = "Port Terminal";

#line default
#line hidden
            DefineSection("Header", async() => {
                BeginContext(106, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(112, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6034bef2e8ad4f4cbddfb7902cedfaed", async() => {
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
                BeginContext(221, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(226, 173, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <div class=\"box\">\r\n            <div class=\"box-header\">\r\n                <h3 class=\"box-title\">\r\n                    ");
            EndContext();
            BeginContext(399, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e3635947fa4254ae2ceb7c2aa7f34d", async() => {
                BeginContext(476, 10, true);
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
            BeginContext(490, 306, true);
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
            BeginContext(797, 38, false);
#line 22 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(835, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(875, 48, false);
#line 23 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.terminalPort));

#line default
#line hidden
            EndContext();
            BeginContext(923, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(963, 43, false);
#line 24 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1046, 49, false);
#line 25 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.portOfLoading));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1135, 44, false);
#line 26 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1219, 45, false);
#line 27 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1304, 45, false);
#line 28 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1389, 45, false);
#line 29 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1474, 45, false);
#line 30 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 142, true);
            WriteLiteral("</th>\r\n                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 35 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                         foreach (var item in ViewBag.Items)
                        {

#line default
#line hidden
            BeginContext(1750, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1821, 7, false);
#line 38 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1872, 17, false);
#line 39 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.terminalPort);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1933, 12, false);
#line 40 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                 if (@item.portOfLoading != null)
                                {

#line default
#line hidden
            BeginContext(2054, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2095, 23, false);
#line 43 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                   Write(item.portOfLoading.port);

#line default
#line hidden
            EndContext();
            BeginContext(2118, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2233, 53, true);
            WriteLiteral("                                    <td>&nbsp;</td>\r\n");
            EndContext();
#line 48 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                 if (@item.isActive)
                                {

#line default
#line hidden
            BeginContext(2412, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2452, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1738efdadeed4cff867db64ef75dc99a", async() => {
                BeginContext(2555, 4, true);
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
#line 52 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
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
            BeginContext(2563, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-success\">True</span></td> -->\r\n");
            EndContext();
#line 54 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2778, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2818, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cac2d8f483bb4f87bd36385928f81459", async() => {
                BeginContext(2920, 5, true);
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
#line 57 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
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
            BeginContext(2929, 107, true);
            WriteLiteral("</td>\r\n                                    <!--<td><span class=\"label label-danger\">False</span></td> -->\r\n");
            EndContext();
#line 59 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3071, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(3108, 14, false);
#line 60 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(3122, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3166, 47, false);
#line 61 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.createdOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3213, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3257, 14, false);
#line 62 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.updatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3271, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3315, 47, false);
#line 63 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                               Write(item.updatedOn.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3362, 494, true);
            WriteLiteral(@"</td>
                                <td>
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                            <span class=""caret""></span>
                                        </button>
                                        <ul class=""dropdown-menu"">
                                            <li>");
            EndContext();
            BeginContext(3856, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f137c054e14a43fd8b57cc10dc5e6939", async() => {
                BeginContext(3931, 4, true);
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
#line 70 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
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
            BeginContext(3939, 55, true);
            WriteLiteral("</li>\r\n                                            <li>");
            EndContext();
            BeginContext(3994, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a45ecaea68f48e6b5c2a9340c0f5e16", async() => {
                BeginContext(4113, 6, true);
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
#line 71 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
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
            BeginContext(4123, 172, true);
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 76 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4322, 121, true);
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(4444, 38, false);
#line 80 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(4482, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4522, 48, false);
#line 81 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.terminalPort));

#line default
#line hidden
            EndContext();
            BeginContext(4570, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4610, 43, false);
#line 82 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(4653, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4693, 51, false);
#line 83 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.portOfLoadingId));

#line default
#line hidden
            EndContext();
            BeginContext(4744, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4784, 44, false);
#line 84 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(4828, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4868, 45, false);
#line 85 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdBy));

#line default
#line hidden
            EndContext();
            BeginContext(4913, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(4953, 45, false);
#line 86 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdOn));

#line default
#line hidden
            EndContext();
            BeginContext(4998, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5038, 45, false);
#line 87 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(5083, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(5123, 45, false);
#line 88 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.updatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(5168, 272, true);
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
                BeginContext(5457, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5470, "\"", 5562, 1);
#line 101 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
WriteAttributeValue("", 5476, Url.Content("~/AdminLTE/bower_components/datatables.net/js/jquery.dataTables.min.js"), 5476, 86, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5563, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5586, "\"", 5684, 1);
#line 102 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/PortTerminal/Index.cshtml"
WriteAttributeValue("", 5592, Url.Content("~/AdminLTE/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), 5592, 92, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5685, 88, true);
                WriteLiteral("></script>\r\n    <script>$(function () {\r\n    $(\'#example1\').DataTable()\r\n  })</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fms.Models.mtPortTerminal> Html { get; private set; }
    }
}
#pragma warning restore 1591
