#pragma checksum "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd8c75ce04d097c5f12d6acc6f2b194e6e3b317b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Package_Index), @"mvc.1.0.view", @"/Views/Package/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
using DistantPointTest.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8c75ce04d097c5f12d6acc6f2b194e6e3b317b", @"/Views/Package/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9340f4c1fba0aac0154612d5cb58e2b72e082c3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Package_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DistantPointTest.Entities.Package>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <h3>All Orders</h3>\r\n    </div>\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 13 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <table>\r\n                    <tr class=\"table-bordered\">\r\n                        <th>");
#nullable restore
#line 18 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
                       Write(order.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 19 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
                       Write(order.CourierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 20 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
                       Write(order.cubicCM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 21 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
                       Write(order.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\Dell\source\repos\DistantPointTest\DistantPointTest\Views\Package\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DistantPointTest.Entities.Package>> Html { get; private set; }
    }
}
#pragma warning restore 1591
