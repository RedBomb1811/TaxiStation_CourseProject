#pragma checksum "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a324d35e4891fb247cd2e1688473cf8d775c928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_MonitorOrders), @"mvc.1.0.view", @"/Views/Orders/MonitorOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/MonitorOrders.cshtml", typeof(AspNetCore.Views_Orders_MonitorOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a324d35e4891fb247cd2e1688473cf8d775c928", @"/Views/Orders/MonitorOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d2d6596708268f266776e4faece84fcb83c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_MonitorOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestExample.DB.NotAcceptedOrdersForDriver_Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
  
    ViewData["Title"] = "MonitorOrders";

#line default
#line hidden
            BeginContext(121, 37, true);
            WriteLiteral("\r\n<h1>MonitorOrders</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(159, 49, false);
#line 10 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
Write(Html.ActionLink("Закончить смену", "End", "Turn"));

#line default
#line hidden
            EndContext();
            BeginContext(208, 104, true);
            WriteLiteral("\r\n    <br />\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(313, 45, false);
#line 17 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.id_client));

#line default
#line hidden
            EndContext();
            BeginContext(358, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(414, 42, false);
#line 20 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.rating));

#line default
#line hidden
            EndContext();
            BeginContext(456, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(512, 52, false);
#line 23 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.date_start_order));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 51, false);
#line 26 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.order_type_name));

#line default
#line hidden
            EndContext();
            BeginContext(671, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(727, 51, false);
#line 29 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.start_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(778, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(834, 52, false);
#line 32 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.start_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(886, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(942, 49, false);
#line 35 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.end_point_lat));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1047, 50, false);
#line 38 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.end_point_long));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1153, 41, false);
#line 41 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.child));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1250, 40, false);
#line 44 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\MonitorOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.pets));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 104, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"tbody_orders\">\r\n");
            EndContext();
            BeginContext(2628, 28, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2656, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a324d35e4891fb247cd2e1688473cf8d775c9289107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2707, 2068, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        loadData();
        setInterval(loadData, 1000 * 5);
    });

    function loadData() {
        $.ajax({
            url: ""/Order/GetListOfOrders"",
            type: ""GET"",
            contentType: ""application/json;charset=utf-8"",
            dataType: ""json"",
            success: function (result) {
                var html = '';
                $.each(result, function (key, item) {
                    html += '<tr>';
                    html += '<td>' + item.id_client + '</td>';
                    html += '<td>' + item.rating + '</td>';
                    var d = new Date(item.date_start_order);
                    var datestring = ""<b>""+(""0"" + d.getHours()).slice(-2) + "":"" + (""0"" + d.getMinutes()).slice(-2) + ""</b> "" +
                        (""0"" + d.getDate()).slice(-2) + ""-"" + (""0"" + (d.getMonth() + 1)).slice(-2) + ""-"" + d.getFullYear();
                    html += '<td>' + datestring + '</td>';
      ");
            WriteLiteral(@"              html += '<td>' + item.order_type_name + '</td>';
                    html += '<td>' + item.start_point_lat + '</td>';
                    html += '<td>' + item.start_point_long + '</td>';
                    html += '<td>' + item.end_point_lat + '</td>';
                    html += '<td>' + item.end_point_long + '</td>';
                    html += '<td>' + '<input type=""checkbox"" class=""custom-checkbox"" disabled=""disabled"" ' + (item.child?'checked=""checked""':'') + '/>' + '</td>';
                    html += '<td>' + '<input type=""checkbox"" class=""custom-checkbox"" disabled=""disabled"" ' + (item.pets?'checked=""checked""':'') + '/>' + '</td>';
                    html += '<td>' + '<a href=""/Order/Accept/' + item.order_id + '"">Принять</a>' + '</td>';
                    html += '</tr>';
                });
                $('#tbody_orders').html(html);
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });");
            WriteLiteral("\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestExample.DB.NotAcceptedOrdersForDriver_Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
