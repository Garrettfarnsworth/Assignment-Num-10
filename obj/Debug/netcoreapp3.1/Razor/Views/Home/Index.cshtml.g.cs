#pragma checksum "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e6b1cff109a4a3a729784103ae2f0ce995e59b"
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
#line 1 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\_ViewImports.cshtml"
using BowlingLeague.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e6b1cff109a4a3a729784103ae2f0ce995e59b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca3d7193138885689bed8eea0df3221787f4fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BowlingLeague.Infrastructure.PaginationTagHelper __BowlingLeague_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center m-1 p-2\" style=\"background-color: #5D737E\">\n    <div class=\"m-4\">\n");
#nullable restore
#line 9 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
         if (Model.TeamName == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"display-4\">All Teams</h2>\n");
#nullable restore
#line 12 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"display-4\">");
#nullable restore
#line 15 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                             Write(Model.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 16 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 18 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
     foreach (var x in Model.Bowlers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-center m-1\" style=\"background-color: #EAF8BF\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 22 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                                  Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                                                     Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                                                                         Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"card-text\">\n                    <span class=\"font-weight-bold\">Address:</span>\n                    ");
#nullable restore
#line 25 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
               Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                    ");
#nullable restore
#line 26 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
               Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 26 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                              Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                                             Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <p><span class=\"font-weight-bold\">Phone Number:</span> ");
#nullable restore
#line 28 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
                                                                  Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n");
#nullable restore
#line 31 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e6b1cff109a4a3a729784103ae2f0ce995e59b9092", async() => {
                WriteLiteral("\n\n");
            }
            );
            __BowlingLeague_Infrastructure_PaginationTagHelper = CreateTagHelper<global::BowlingLeague.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__BowlingLeague_Infrastructure_PaginationTagHelper);
#nullable restore
#line 34 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumbering;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __BowlingLeague_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-teamName", "BowlingLeague.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 35 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs["teamName"] = Model.TeamName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-teamName", __BowlingLeague_Infrastructure_PaginationTagHelper.KeyValuePairs["teamName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "\\Mac\Home\Desktop\BowlingLeague-master-2\BowlingLeague\Views\Home\Index.cshtml"
__BowlingLeague_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __BowlingLeague_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __BowlingLeague_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __BowlingLeague_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __BowlingLeague_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
