#pragma checksum "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7118a1c1974dd44d1765fcae2fe51c7e4cc24e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7118a1c1974dd44d1765fcae2fe51c7e4cc24e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990961b62ecabdbf2691166db10aaec653f38c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    <center>\r\n        <h1 class=\"display-4\">AU For Medical Science</h1>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Patches\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 415, "\"", 498, 3);
            WriteAttributeValue("", 445, "window.location.href=\'", 445, 22, true);
#nullable restore
#line 16 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 467, Url.Action("Index1", "Home" ), 467, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 497, "\'", 497, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h3>\r\n        </h3>\r\n        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Desktop and Priter\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 657, "\"", 742, 3);
            WriteAttributeValue("", 687, "window.location.href=\'", 687, 22, true);
#nullable restore
#line 22 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 709, Url.Action("Index", "Desktop" ), 709, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 741, "\'", 741, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h3>\r\n        </h3>\r\n        <div>\r\n\r\n        </div>\r\n        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Patches In Building\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 935, "\"", 1027, 3);
            WriteAttributeValue("", 965, "window.location.href=\'", 965, 22, true);
#nullable restore
#line 31 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 987, Url.Action("patchInBuilding", "Home" ), 987, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1026, "\'", 1026, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h3>\r\n        </h3>\r\n        <div>\r\n\r\n        </div>\r\n        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Patches In Dept\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 1216, "\"", 1304, 3);
            WriteAttributeValue("", 1246, "window.location.href=\'", 1246, 22, true);
#nullable restore
#line 40 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 1268, Url.Action("patchInDept", "Home" ), 1268, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1303, "\'", 1303, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h3>\r\n        </h3>\r\n        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Patches In Floor\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 1461, "\"", 1550, 3);
            WriteAttributeValue("", 1491, "window.location.href=\'", 1491, 22, true);
#nullable restore
#line 46 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 1513, Url.Action("patchInFloor", "Home" ), 1513, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1549, "\'", 1549, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h3>\r\n        </h3>\r\n        <div>\r\n            <input type=\"button\" class=\"btn btn-primary btn-block\" value=\"Patches In Office\"");
            BeginWriteAttribute("onclick", "\r\n                   onclick=\"", 1708, "\"", 1798, 3);
            WriteAttributeValue("", 1738, "window.location.href=\'", 1738, 22, true);
#nullable restore
#line 52 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index.cshtml"
WriteAttributeValue("", 1760, Url.Action("patchInOffice", "Home" ), 1760, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1797, "\'", 1797, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </center>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
