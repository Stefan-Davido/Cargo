#pragma checksum "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5bc61b29c9bdeab477b8a695fec998b4226179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courier_Index), @"mvc.1.0.view", @"/Views/Courier/Index.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\_ViewImports.cshtml"
using DistantPointTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\_ViewImports.cshtml"
using DistantPointTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5bc61b29c9bdeab477b8a695fec998b4226179", @"/Views/Courier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9340f4c1fba0aac0154612d5cb58e2b72e082c3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DistantPointTest.Entities.Courier>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h3>Couriers</h3>\r\n    </div> \r\n    <div class=\"col-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5bc61b29c9bdeab477b8a695fec998b42261796210", async() => {
                WriteLiteral("Add New Courier");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    <table class=""col-12 table-bordered"">
        <tr>
            <td>Name</td>
            <td>Max Weight</td>
            <td>Min Weight</td>
            <td>Max Dimensions</td>
            <td>Min Dimensions</td>
            <td>Actions</td>
        </tr>
");
#nullable restore
#line 21 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
         foreach (var courier in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"bg-info\">\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(courier.CourierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(courier.MaxWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(courier.MinWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(courier.MaxDimensions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(courier.MinDimensions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5bc61b29c9bdeab477b8a695fec998b42261799438", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
                                           WriteLiteral(courier.CourierId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5bc61b29c9bdeab477b8a695fec998b422617911710", async() => {
                WriteLiteral("Info");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
                                              WriteLiteral(courier.CourierId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5bc61b29c9bdeab477b8a695fec998b422617913986", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
                                             WriteLiteral(courier.CourierId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>                \r\n");
#nullable restore
#line 35 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"

            var pricer = PricerService.GetPricerByCourierId(courier.CourierId);
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <td>Min Weight</td>
                <td>Max Weight</td>
                <td>Price Per Weight</td>
                <td>Min Dimensions</td>
                <td>Max Dimensions</td>
                <td>Price Per Dimensions</td>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 47 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinWeight1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxWeight1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceWeight1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinDimensions1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxDimensions1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceDimension1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n            </tr>    \r\n            <tr>     \r\n                <td>");
#nullable restore
#line 55 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinWeight2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxWeight2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceWeight2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinDimensions2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxDimensions2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceDimension2);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n            </tr>    \r\n            <tr>     \r\n                <td>");
#nullable restore
#line 63 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinWeight3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 64 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxWeight3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 65 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceWeight3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>");
#nullable restore
#line 66 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinDimensions3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 67 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxDimensions3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 68 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceDimension3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n            </tr>    \r\n            <tr>     \r\n                <td>");
#nullable restore
#line 71 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinWeight4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 72 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxWeight4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceWeight4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>");
#nullable restore
#line 74 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MinDimensions4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 75 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.MaxDimensions4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm3</td>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.PriceDimension4);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Extra Kilos</td>\r\n                <td>Start Price For Extra Kilos</td>\r\n                <td>Price per Extra Kilo/s</td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.ExtraWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</td>\r\n                <td>");
#nullable restore
#line 85 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
               Write(pricer.ExtraWeightPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>+ ");
#nullable restore
#line 86 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
                 Write(pricer.AdditionalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Courier\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5bc61b29c9bdeab477b8a695fec998b422617925039", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DistantPointTest.Service.Interfaces.IPricePerCourierService PricerService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DistantPointTest.Entities.Courier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
