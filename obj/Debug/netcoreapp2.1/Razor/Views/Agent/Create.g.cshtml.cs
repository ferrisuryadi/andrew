#pragma checksum "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "458790e605cd808e09c56885985f094c1861349e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agent_Create), @"mvc.1.0.view", @"/Views/Agent/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agent/Create.cshtml", typeof(AspNetCore.Views_Agent_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458790e605cd808e09c56885985f094c1861349e", @"/Views/Agent/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3707bf8577d6690eda379682e04effd996a011e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Agent_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fms.Models.mtAgent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/bower_components/select2/dist/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
  
    ViewData["Title"] = "Agent";

#line default
#line hidden
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Header", async() => {
                BeginContext(89, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(95, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f83ef91b18f4a2bb16ca2705c2d487b", async() => {
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
                BeginContext(186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(191, 296, true);
            WriteLiteral(@"
<div id=""errorMessageHeader"">

</div>

<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box box-primary"">
            <div class=""box-body"">
                <div class=""col-xs-6"">
                    <div class=""form-group"">
                        <label for=""code"">");
            EndContext();
            BeginContext(488, 40, false);
#line 21 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                     Write(Html.DisplayNameFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(528, 212, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"code\" autofocus>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"name\">");
            EndContext();
            BeginContext(741, 40, false);
#line 25 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                     Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(781, 205, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"name\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"address\">");
            EndContext();
            BeginContext(987, 43, false);
#line 29 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                        Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 206, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"address\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"email\">");
            EndContext();
            BeginContext(1237, 41, false);
#line 33 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                      Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 206, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"email\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"website\">");
            EndContext();
            BeginContext(1485, 43, false);
#line 37 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                        Write(Html.DisplayNameFor(model => model.website));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 276, true);
            WriteLiteral(@"</label>
                        <input type=""text"" class=""form-control"" id=""website"" >
                    </div>
                </div>
                <div class=""col-xs-6"">
                    <div class=""form-group"">
                        <label for=""postalCode"">");
            EndContext();
            BeginContext(1805, 46, false);
#line 43 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                           Write(Html.DisplayNameFor(model => model.postalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 252, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"postalCode\" >\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
            EndContext();
            BeginContext(2104, 55, false);
#line 48 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                              Write(Html.DisplayNameFor(model => model.portOfDestinationId));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 155, true);
            WriteLiteral("</label>\r\n                            <select class=\"form-control select2\" style=\"width: 100%;\" id=\"portOfDestinationId\">\r\n                                ");
            EndContext();
            BeginContext(2314, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c989ad72be204b78a08c119a7dd38264", async() => {
                BeginContext(2332, 8, true);
                WriteLiteral("No Value");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2349, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                 foreach (var item in ViewBag.PortOfDestination)
                                {

#line default
#line hidden
            BeginContext(2468, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2504, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d83fc54d6f1c4de6a3d4a192949b53e5", async() => {
                BeginContext(2530, 13, false);
#line 53 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                        Write(item.location);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 53 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2552, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                }

#line default
#line hidden
            BeginContext(2589, 230, true);
            WriteLiteral("                            </select>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
            EndContext();
            BeginContext(2820, 45, false);
#line 60 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                              Write(Html.DisplayNameFor(model => model.shipperId));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 146, true);
            WriteLiteral("</label>\r\n                            <select class=\"form-control select2\" style=\"width: 100%;\" id=\"shipperId\" >\r\n                                ");
            EndContext();
            BeginContext(3011, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d0f078778014d34ac24db700b3be34f", async() => {
                BeginContext(3029, 8, true);
                WriteLiteral("No Value");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3046, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                 foreach (var item in ViewBag.Shipper)
                                {

#line default
#line hidden
            BeginContext(3155, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3191, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09879828f7b344f798bbf6c6d6a7b9bb", async() => {
                BeginContext(3217, 9, false);
#line 65 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                        Write(item.code);

#line default
#line hidden
                EndContext();
                BeginContext(3226, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(3230, 9, false);
#line 65 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                                     Write(item.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 65 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3248, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                }

#line default
#line hidden
            BeginContext(3285, 230, true);
            WriteLiteral("                            </select>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"form-group\">\r\n                            <label>");
            EndContext();
            BeginContext(3516, 42, false);
#line 72 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                              Write(Html.DisplayNameFor(model => model.typeId));

#line default
#line hidden
            EndContext();
            BeginContext(3558, 143, true);
            WriteLiteral("</label>\r\n                            <select class=\"form-control select2\" style=\"width: 100%;\" id=\"typeId\" >\r\n                                ");
            EndContext();
            BeginContext(3701, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179f8ce381d34987848f8fabb3f71b96", async() => {
                BeginContext(3719, 8, true);
                WriteLiteral("No Value");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3736, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                 foreach (var item in ViewBag.Type)
                                {

#line default
#line hidden
            BeginContext(3842, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3878, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e83fbd3803546abb49e6eb2eb8d21fc", async() => {
                BeginContext(3904, 9, false);
#line 77 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                        Write(item.code);

#line default
#line hidden
                EndContext();
                BeginContext(3913, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(3917, 16, false);
#line 77 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                                     Write(item.description);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 77 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3942, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 78 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                }

#line default
#line hidden
            BeginContext(3979, 307, true);
            WriteLiteral(@"                            </select>
                        </div>
                    </div>
                </div>
                <div class=""col-xs-12"">
                    <div class=""checkbox"">
                        <label>
                            <input type=""checkbox"" id=""isActive""> ");
            EndContext();
            BeginContext(4287, 44, false);
#line 86 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(4331, 259, true);
            WriteLiteral(@"
                        </label>
                    </div>
                </div>
            </div>

            <div class=""box-footer"">
                <button id=""submit"" type=""submit"" class=""btn btn-primary"">Save</button>&nbsp;
                ");
            EndContext();
            BeginContext(4590, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc702de0df954094afd067cbd26e5b85", async() => {
                BeginContext(4659, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4669, 2286, true);
            WriteLiteral(@"
            </div>

        </div>
    </div>
    <div class=""col-xs-12"">
        <div class=""box"">
            <!-- /.box-header -->
            <div class=""box-body table-responsive"">
                <table class=""table table-bordered table-striped"" id=""agentDetails"">
                    <thead>
                        <tr>
                            <th>Contact Person</th>
                            <th>Telepon</th>
                            <th>Position</th>
                            <th>Address</th>
                            <th>Handphone</th>
                            <th>Email</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""mycontainer"">
                            <td>
                                <input type=""text"" id=""detailContactPerson"" class=""form-control"" maxlength=""50"" />
                            </td>
                            <");
            WriteLiteral(@"td>
                                <input type=""text"" id=""detailTelepon"" class=""form-control"" maxlength=""50"" />
                            </td>
                            <td>
                                <input type=""text"" id=""detailPosition"" class=""form-control"" maxlength=""50"" />
                            </td>
                            <td>
                                <input type=""text"" id=""detailAddress"" class=""form-control"" maxlength=""500"" />
                            </td>
                            <td>
                                <input type=""text"" id=""detailHandphone"" class=""form-control"" maxlength=""50"" />
                            </td>
                            <td>
                                <input type=""text"" id=""detailEmail"" class=""form-control"" maxlength=""250"" />
                            </td>
                            <td>
                                <input type=""button"" id=""add"" value=""Add"" style=""width: 80px"" class=""btn btn-success"" />");
            WriteLiteral("\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <!-- /.box-body -->\r\n        </div>\r\n        <!-- /.box -->\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6972, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6985, "\"", 7050, 1);
#line 149 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
WriteAttributeValue("", 6991, Url.Content("https://code.jquery.com/jquery-2.2.4.min.js"), 6991, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7051, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7074, "\"", 7159, 1);
#line 150 "/Users/ferrisuryadi/Documents/Project/Forwarding/fms/Views/Agent/Create.cshtml"
WriteAttributeValue("", 7080, Url.Content("~/AdminLTE/bower_components/select2/dist/js/select2.full.min.js"), 7080, 79, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7160, 6740, true);
                WriteLiteral(@"></script>

    <script>
         $(function () {
            $('.select2').select2()
        })

        $(""#add"").click(function (e) {
            e.preventDefault();

            if ($.trim($(""#detailContactPerson"").val()) == """" ||
                $.trim($(""#detailTelepon"").val()) == """" ||
                $.trim($(""#detailPosition"").val()) == """" ||
                $.trim($(""#detailAddress"").val()) == """" ||
                $.trim($(""#detailHandphone"").val()) == """" ||
                $.trim($(""#detailEmail"").val()) == """") return;

            var contactPerson = $(""#detailContactPerson"").val(),
                telepon = $(""#detailTelepon"").val(),
                position = $(""#detailPosition"").val(),
                address = $(""#detailAddress"").val(),
                handphone = $(""#detailHandphone"").val(),
                email = $(""#detailEmail"").val(),
                detailsTableBody = $(""#agentDetails tbody"");

            var Item = '<tr><td>' + contactPerson + '</td><td>' + t");
                WriteLiteral(@"elepon + '</td><td>' + position + '</td><td>' + address + '</td><td>' + handphone + '</td><td>' + email +'</td><td> <input type=""button"" data-itemId=""0"" href=""#"" style=""width: 80px"" value=""Remove"" class=""deleteItem btn btn-danger"" /> </td></tr>';
            detailsTableBody.append(Item);
            clearItem();
        });

        function clearItem() {
            $(""#detailContactPerson"").val('');
            $(""#detailTelepon"").val('');
            $(""#detailPosition"").val('');
            $(""#detailAddress"").val('');
            $(""#detailHandphone"").val('');
            $(""#detailEmail"").val('');
        }

        $(document).on('click', 'a.deleteItem', function (e) {
            e.preventDefault();
            var $self = $(this);
            if ($(this).attr('data-itemId') == ""0"") {
                $(this).parents('tr').css(""background-color"", ""#ff6347"").fadeOut(800, function () {
                    $(this).remove();
                });
            }
        });

        //");
                WriteLiteral(@"Collect Multiple Order List For Pass To Controller
        $(""#submit"").click(function (e) {
            e.preventDefault();

            var details = [];
            details.length = 0;
            var i = 0;

            $.each($(""#agentDetails tbody tr""), function () {
                if (i == 0) {
                    i = 1;
                }else{
                    details.push({
                        contactPerson: $(this).find('td:eq(0)').html(),
                        telepon: $(this).find('td:eq(1)').html(),
                        position: $(this).find('td:eq(2)').html(),
                        address: $(this).find('td:eq(3)').html(),
                        handphone: $(this).find('td:eq(4)').html(),
                        email: $(this).find('td:eq(5)').html()
                    });
                }
            });

            var isChecked = $('#isActive').is("":checked"");
            var isCheck;

            if (isChecked) {
                isCheck = 1;
   ");
                WriteLiteral(@"         }
            else{
                isCheck = 0;
            }

            var data = JSON.stringify({
                code: $('#code').val().trim(),
                name: $('#name').val().trim(),
                address: $('#address').val().trim(),
                email: $('#email').val().trim(),
                website: $('#website').val().trim(),
                postalCode: $('#postalCode').val().trim(),
                portOfDestinationId: $('#portOfDestinationId').val(),
                shipperId: $('#shipperId').val(),
                typeId: $('#typeId').val(),
                isActive: isCheck,
                agentDetails: details
            });

            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: ""/Agent/add"",
                data: data,
                success: function (result) {
                    console.log(result);
                    swit");
                WriteLiteral(@"ch (result.status) {
                        case 200:
                            window.location.href = '/Agent/';
                            break;
                        case 400:
                            $('#divError').remove();
                            var element = document.getElementById(""errorMessageHeader"");
                            var error = '';
                            for (var i=0; i < result.message.length; i++) {
                                console.log(result.message[i]);
                                error = error + '<li>' + result.message[i] + '</li>';
                            }

                            var alert = '<div class=""alert alert-danger alert-dismissible"" id = ""divError""> <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button><h4><i class=""icon fa fa-ban""></i> Error!</h4><div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>' + error + '</ul></div></div>';

                            element.");
                WriteLiteral(@"innerHTML = alert;
                            console.log(alert);
                            break;
                        case 409:
                            $('#divError').remove();
                            var element = document.getElementById(""errorMessageHeader"");
                            var error = '<li>' + result.message + '</li>';
                            var alert = '<div class=""alert alert-danger alert-dismissible"" id = ""divError""> <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button><h4><i class=""icon fa fa-ban""></i> Error!</h4><div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>' + error + '</ul></div></div>';

                            element.innerHTML = alert;
                            console.log(alert);
                            break;
                    }
                },
                error: function (result) {
                    $('#divError').remove();
                    var element = document.g");
                WriteLiteral(@"etElementById(""errorMessageHeader"");
                    var error = '<li>Error! Check Console</li>';
                    var alert = '<div class=""alert alert-danger alert-dismissible"" id = ""divError""> <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button><h4><i class=""icon fa fa-ban""></i> Error!</h4><div class=""validation-summary-errors"" data-valmsg-summary=""true""><ul>' + error + '</ul></div></div>';

                    element.innerHTML = alert;
                    console.log(result);
                }
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fms.Models.mtAgent> Html { get; private set; }
    }
}
#pragma warning restore 1591
