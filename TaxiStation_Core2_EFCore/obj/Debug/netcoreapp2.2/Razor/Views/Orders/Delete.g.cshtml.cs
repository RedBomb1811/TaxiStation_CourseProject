#pragma checksum "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c962dfa3e70305b093562207e8239be18d1ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Delete), @"mvc.1.0.view", @"/Views/Orders/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Delete.cshtml", typeof(AspNetCore.Views_Orders_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c962dfa3e70305b093562207e8239be18d1ce5", @"/Views/Orders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d2d6596708268f266776e4faece84fcb83c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestExample.DB.Orders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 176, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Orders</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(251, 45, false);
#line 15 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.id_client));

#line default
#line hidden
            EndContext();
            BeginContext(296, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(360, 41, false);
#line 18 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.id_client));

#line default
#line hidden
            EndContext();
            BeginContext(401, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(464, 44, false);
#line 21 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.id_turns));

#line default
#line hidden
            EndContext();
            BeginContext(508, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 40, false);
#line 24 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.id_turns));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 52, false);
#line 27 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_start_order));

#line default
#line hidden
            EndContext();
            BeginContext(727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 48, false);
#line 30 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_start_order));

#line default
#line hidden
            EndContext();
            BeginContext(839, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(902, 51, false);
#line 33 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_start_trip));

#line default
#line hidden
            EndContext();
            BeginContext(953, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1017, 47, false);
#line 36 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_start_trip));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1127, 49, false);
#line 39 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.date_end_trip));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1240, 45, false);
#line 42 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.date_end_trip));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1348, 49, false);
#line 45 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.id_order_type));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1461, 45, false);
#line 48 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.id_order_type));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1569, 51, false);
#line 51 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.start_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1684, 47, false);
#line 54 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.start_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1794, 52, false);
#line 57 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.start_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1910, 48, false);
#line 60 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.start_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2021, 49, false);
#line 63 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.end_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2134, 45, false);
#line 66 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.end_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2242, 50, false);
#line 69 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.end_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(2292, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2356, 46, false);
#line 72 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.end_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2465, 49, false);
#line 75 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.security_code));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2578, 45, false);
#line 78 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.security_code));

#line default
#line hidden
            EndContext();
            BeginContext(2623, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2686, 45, false);
#line 81 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.confirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2795, 41, false);
#line 84 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.confirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2899, 40, false);
#line 87 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(2939, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3003, 36, false);
#line 90 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(3039, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3102, 41, false);
#line 93 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3207, 37, false);
#line 96 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(3244, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3282, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86c962dfa3e70305b093562207e8239be18d1ce517170", async() => {
                BeginContext(3308, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3318, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86c962dfa3e70305b093562207e8239be18d1ce517563", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3354, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3437, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86c962dfa3e70305b093562207e8239be18d1ce519477", async() => {
                    BeginContext(3459, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3475, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3488, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestExample.DB.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
