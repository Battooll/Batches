#pragma checksum "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc11ea69e4d90d302cd79f7ef094a7e6e1ec2418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc11ea69e4d90d302cd79f7ef094a7e6e1ec2418", @"/Views/Home/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990961b62ecabdbf2691166db10aaec653f38c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OfficehHierarchyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPatch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
      
        ViewBag.Title = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"font-family:Arial\">\r\n        <h2>Patches List</h2>\r\n        <center>\r\n            <p>\r\n");
#nullable restore
#line 10 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
                 using (@Html.BeginForm("Index1", "Home", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <b>Search By:</b>\r\n");
#nullable restore
#line 13 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.RadioButton("searchBy", "Building", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("Building");
#nullable restore
#line 14 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.RadioButton("searchBy", "Patch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Patch");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 15 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.RadioButton("searchBy", "Floor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Floor");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 16 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.RadioButton("searchBy", "Office"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Office");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 17 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.RadioButton("searchBy", "Dept"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Dept");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 18 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3></h3><input type=\"submit\" class=\"btn btn-primary\" value=\"search\" />\r\n");
#nullable restore
#line 19 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc11ea69e4d90d302cd79f7ef094a7e6e1ec24186617", async() => {
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            \r\n        </center>\r\n        <h2></h2>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.patch.PatchNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.patch.PatchSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.patch.BoxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Office Name\r\n");
            WriteLiteral("                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.patch.Office.OfficeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Dept Name\r\n");
            WriteLiteral("                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.floor.FloorNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Building Name\r\n");
            WriteLiteral("                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 60 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
               Write(Html.DisplayNameFor(model => model.patch.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Action</th>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\">\r\n                        No records match search criteria\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
            }
            else
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.PatchNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.PatchSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.BoxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.Office.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.Office.OfficeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.dept.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.floor.FloorNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.building.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.DisplayFor(modelItem => item.patch.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 105 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.ActionLink("Edit", "EditPatch", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 106 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.ActionLink("Details", "PatchDetails", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 107 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 110 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\Index1.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OfficehHierarchyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591