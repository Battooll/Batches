#pragma checksum "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c4e84243d0f074ecc3ea09b1d66bec3f923a75d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Desktop_Index), @"mvc.1.0.view", @"/Views/Desktop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4e84243d0f074ecc3ea09b1d66bec3f923a75d", @"/Views/Desktop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990961b62ecabdbf2691166db10aaec653f38c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Desktop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesktopViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDesktop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
  
    ViewBag.Title = "AU Desktop and Pribter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"card-deck\">\r\n    <h1 class=\"display-4\">AU For Medical Science</h1>\r\n    <p>\r\n        AU Desktop and Pribter\r\n    </p>\r\n    <center>\r\n        <p>\r\n");
#nullable restore
#line 16 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
             using (@Html.BeginForm("Index", "Desktop", FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b>Search By:</b>\r\n");
#nullable restore
#line 19 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
           Write(Html.RadioButton("searchBy", "Device Name", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("Device Name");
#nullable restore
#line 20 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
           Write(Html.RadioButton("searchBy", "IP"));

#line default
#line hidden
#nullable disable
            WriteLiteral("IP");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 21 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
           Write(Html.RadioButton("searchBy", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("User");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 22 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
           Write(Html.RadioButton("searchBy", "Em"));

#line default
#line hidden
#nullable disable
            WriteLiteral("EM");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 23 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
           Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3></h3><input type=\"submit\" class=\"btn btn-primary\" value=\"search\" />\r\n");
#nullable restore
#line 24 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c4e84243d0f074ecc3ea09b1d66bec3f923a75d6333", async() => {
                WriteLiteral("<i class=\"fa fa-table\"></i> add new ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </center>\r\n    <h2>\r\n    </h2>\r\n    <h2></h2>\r\n");
#nullable restore
#line 36 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><em>Not Found...</em></p>\r\n");
#nullable restore
#line 39 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
            WriteLiteral("<text>NO</text></th>\r\n                    <th>");
            WriteLiteral("<text>Device Name</text></th>\r\n                    <th>");
            WriteLiteral("<text>User</text></th>\r\n                    <th>");
            WriteLiteral("<text>EM</text></th>\r\n                    <th>");
            WriteLiteral("<text>Department</text></th>\r\n                    <th>");
            WriteLiteral("<text>IP</text></th>\r\n                    <th>");
            WriteLiteral("<text>DC</text></th>\r\n                    <th>");
            WriteLiteral("<text>AV</text></th>\r\n                    <th>");
            WriteLiteral("<text>EX</text></th>\r\n                    <th>");
            WriteLiteral("<text>Office</text></th>\r\n                    <th>");
            WriteLiteral("<text>Floor</text></th>\r\n                    <th>");
            WriteLiteral("<text>Building</text></th>\r\n                    <th>Action</th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 60 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\">\r\n                        No records match search criteria\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 67 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n\r\n");
#nullable restore
#line 72 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.IddesktopPribter));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Ds.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Em));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 79 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OfficehHierarchy.dept.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 80 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 81 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Dc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Av));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 83 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Ex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.desktop.Office.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OfficehHierarchy.floor.FloorNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OfficehHierarchy.building.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.ActionLink("Edit", "EditDesktop", new { id = item.desktop.IddesktopPribter }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 89 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.ActionLink("Details", "desktopDetails", new { id = item.desktop.IddesktopPribter }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                ");
#nullable restore
#line 90 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.desktop.IddesktopPribter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n");
#nullable restore
#line 95 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 97 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Desktop\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesktopViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
