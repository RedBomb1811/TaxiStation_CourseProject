#pragma checksum "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b9b7587ed4a990e835487f2e87b0bee4d75d89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venichles_Index), @"mvc.1.0.view", @"/Views/Venichles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venichles/Index.cshtml", typeof(AspNetCore.Views_Venichles_Index))]
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
#line 1 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\_ViewImports.cshtml"
using TaxiStation_Core2_EFCore;

#line default
#line hidden
#line 2 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\_ViewImports.cshtml"
using TaxiStation_Core2_EFCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b9b7587ed4a990e835487f2e87b0bee4d75d89", @"/Views/Venichles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d2d6596708268f266776e4faece84fcb83c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Venichles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaxiStation_Core2_EFCore.Models.ViewModels.AddVenichle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Venichle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(119, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(148, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b9b7587ed4a990e835487f2e87b0bee4d75d894822", async() => {
                BeginContext(171, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(278, 42, false);
#line 16 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.number));

#line default
#line hidden
            EndContext();
            BeginContext(320, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(376, 41, false);
#line 19 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 40, false);
#line 22 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(513, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(569, 41, false);
#line 25 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.model));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(666, 52, false);
#line 28 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id_venichle_type));

#line default
#line hidden
            EndContext();
            BeginContext(718, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(836, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(885, 41, false);
#line 37 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.number));

#line default
#line hidden
            EndContext();
            BeginContext(926, 40, true);
            WriteLiteral("/td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(967, 40, false);
#line 39 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.child));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1063, 39, false);
#line 42 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.pets));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1158, 40, false);
#line 45 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.model));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1254, 125, false);
#line 48 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => (ViewData["Id_venicle_type"] as List<TestExample.DB.Order_types>)[item.id_venichle_type+1].name));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1434, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b9b7587ed4a990e835487f2e87b0bee4d75d8910985", async() => {
                BeginContext(1509, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
                                                                 WriteLiteral(item.number);

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
            BeginContext(1517, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1537, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b9b7587ed4a990e835487f2e87b0bee4d75d8913576", async() => {
                BeginContext(1614, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
                                                                   WriteLiteral(item.number);

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
            BeginContext(1624, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Venichles\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1663, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaxiStation_Core2_EFCore.Models.ViewModels.AddVenichle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
