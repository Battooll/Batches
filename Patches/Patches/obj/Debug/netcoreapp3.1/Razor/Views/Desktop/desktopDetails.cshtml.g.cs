#pragma checksum "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eee0470e18ca2e7ff45d5b4da9b988eac702a7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desktop_desktopDetails), @"mvc.1.0.view", @"/Views/Desktop/desktopDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee0470e18ca2e7ff45d5b4da9b988eac702a7b", @"/Views/Desktop/desktopDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990961b62ecabdbf2691166db10aaec653f38c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Desktop_desktopDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesktopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h4>Desktop Details</h4>\r\n<hr />\r\n<center>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 7 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><em>Nothing Found...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table"">
                    <thead>
                        <tr>
                            <th>No</th>
                            <th>DeviceName</th>
                            <th>User</th>
                            <th>EM</th>
                            <th>Department</th>
                            <th>IP</th>
                            <th>DC</th>
                            <th>AV</th>
                            <th>EX</th>
                            <th>Office</th>
                            <th>Floor</th>
                            <th>Building</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>");
#nullable restore
#line 32 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.IddesktopPribter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Ds.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Em);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.OfficehHierarchy.dept.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Ip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Dc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Av);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Ex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.desktop.Office.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.OfficehHierarchy.floor.FloorNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
                           Write(Model.OfficehHierarchy.building.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 49 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eee0470e18ca2e7ff45d5b4da9b988eac702a7b9244", async() => {
                WriteLiteral("<i class=\"fa fa-table\"></i> Back to List");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</center>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\desktopDetails.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesktopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
