#pragma checksum "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d331bea379f91b1e40d2328a32cd76572f0cfd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SubscriptionManagement_Views_Subscription_Edit), @"mvc.1.0.view", @"/Areas/SubscriptionManagement/Views/Subscription/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SubscriptionManagement/Views/Subscription/Edit.cshtml", typeof(AspNetCore.Areas_SubscriptionManagement_Views_Subscription_Edit))]
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
#line 1 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\_ViewImports.cshtml"
using ContosoAssets.WebApp;

#line default
#line hidden
#line 2 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\_ViewImports.cshtml"
using ContosoAssets.WebApp.Models;

#line default
#line hidden
#line 4 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
using ContosoAssets.SolutionManagement.AzureMarketplaceFulfillment;

#line default
#line hidden
#line 5 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
using ContosoAssets.SolutionManagement.Data;

#line default
#line hidden
#line 6 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
using ContosoAssets.SolutionManagement.SubscriptionManagement;

#line default
#line hidden
#line 7 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d331bea379f91b1e40d2328a32cd76572f0cfd8", @"/Areas/SubscriptionManagement/Views/Subscription/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7f9da3ed9cf885709cb2fdf8d3c16f71f551bc", @"/Areas/SubscriptionManagement/Views/_ViewImports.cshtml")]
    public class Areas_SubscriptionManagement_Views_Subscription_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoAssets.WebApp.Areas.SubscriptionManagement.Models.SubscriptionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelSubscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReActivateSubsription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(448, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(490, 94, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <h4>Subscription management - ");
            EndContext();
            BeginContext(585, 29, false);
#line 16 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
                                 Write(Model.CurrentSku.SalesChannel);

#line default
#line hidden
            EndContext();
            BeginContext(614, 57, true);
            WriteLiteral("</h4>\r\n        <hr/>\r\n    </div>\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 20 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
         if (Model.Subscription.State != SubscriptionState.Complete)
        {

#line default
#line hidden
            BeginContext(752, 124, true);
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                Subscription is not active.\r\n            </div>\r\n");
            EndContext();
#line 25 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(887, 158, true);
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm-4\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1046, 51, false);
#line 32 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.CurrentSku.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1182, 47, false);
#line 35 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.CurrentSku.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1314, 60, false);
#line 38 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Subscription.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1459, 56, false);
#line 41 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Subscription.CreatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1600, 66, false);
#line 44 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Subscription.LastOperationTime));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1751, 62, false);
#line 47 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Subscription.LastOperationTime));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1898, 54, false);
#line 50 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Subscription.State));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2037, 50, false);
#line 53 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Subscription.State));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2172, 52, false);
#line 56 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.MonthToDateUsage));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2309, 48, false);
#line 59 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.MonthToDateUsage));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2442, 46, false);
#line 62 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalUsage));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2573, 42, false);
#line 65 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
               Write(Html.DisplayFor(model => model.TotalUsage));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 92, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n");
            EndContext();
#line 70 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
             if (Model.Subscription.State == SubscriptionState.Complete)
            {

#line default
#line hidden
            BeginContext(2796, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2812, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd816110", async() => {
                BeginContext(2894, 192, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Cancel subscription\" class=\"btn btn-primary\"/>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3093, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 77 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
            }
            else if (Model.CurrentSku.SalesChannel != SalesChannelEnum.Azure)
            {

#line default
#line hidden
            BeginContext(3204, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3220, 288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd818750", async() => {
                BeginContext(3305, 196, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Reactivate subscription\" class=\"btn btn-primary\"/>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3508, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 85 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
            }

#line default
#line hidden
            BeginContext(3525, 43, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <br/>\r\n\r\n");
            EndContext();
#line 91 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
     if (Model.Subscription.State == SubscriptionState.Complete)
    {

#line default
#line hidden
            BeginContext(3641, 126, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3767, 1275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd821805", async() => {
                BeginContext(3835, 73, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            ");
                EndContext();
                BeginContext(3908, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd822265", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 98 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3974, 358, true);
                WriteLiteral(@"
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <label class=""control-label font-weight-bold"">Update subscription</label>
                            </div>

                            <div class=""col-sm-2"">
                                ");
                EndContext();
                BeginContext(4332, 258, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd824448", async() => {
                    BeginContext(4450, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(4488, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd824891", async() => {
                        BeginContext(4525, 13, true);
                        WriteLiteral("Please select");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4547, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 106 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrentSku.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 106 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.AvailableSkus, "Id", "Name"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4590, 326, true);
                WriteLiteral(@"
                            </div>
                            <div class=""col-sm-8"">
                                <input type=""submit"" value=""Update"" class=""btn btn-primary""/>
                            </div>
                        </div>

                        <div class=""row"">
                            ");
                EndContext();
                BeginContext(4916, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d331bea379f91b1e40d2328a32cd76572f0cfd828872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 116 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrentSku);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4981, 54, true);
                WriteLiteral("\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5042, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 122 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
    }

#line default
#line hidden
            BeginContext(5111, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5139, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 126 "D:\Projects\ContosoAssets\src\ContosoAssets.WebApp\Areas\SubscriptionManagement\Views\Subscription\Edit.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISubscriptionManager subscriptionManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoAssets.WebApp.Areas.SubscriptionManagement.Models.SubscriptionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591