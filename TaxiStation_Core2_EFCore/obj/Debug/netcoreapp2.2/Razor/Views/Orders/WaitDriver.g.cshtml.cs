#pragma checksum "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d5c43f9cca698a1fbda774a51358b0a80ac7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_WaitDriver), @"mvc.1.0.view", @"/Views/Orders/WaitDriver.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/WaitDriver.cshtml", typeof(AspNetCore.Views_Orders_WaitDriver))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d5c43f9cca698a1fbda774a51358b0a80ac7c1", @"/Views/Orders/WaitDriver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d2d6596708268f266776e4faece84fcb83c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_WaitDriver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
  
    ViewData["Title"] = "WaitDriver";

#line default
#line hidden
            BeginContext(48, 54, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">Ожидайте водителя</h1>\r\n\r\n\r\n");
            EndContext();
            BeginContext(102, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d5c43f9cca698a1fbda774a51358b0a80ac7c13991", async() => {
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
            BeginContext(153, 111, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        window.location.replace(\'/Info/");
            EndContext();
            BeginContext(265, 20, false);
#line 12 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                                  Write(ViewData["id_order"]);

#line default
#line hidden
            EndContext();
            BeginContext(285, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(287, 20, false);
#line 12 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                                                        Write(ViewData["sec_code"]);

#line default
#line hidden
            EndContext();
            BeginContext(307, 154, true);
            WriteLiteral("\')\r\n        //loadData();\r\n        //setInterval(loadData, 1000 * 5);\r\n    });\r\n\r\n    function loadData() {\r\n        $.ajax({\r\n            url: \'InfoJson/");
            EndContext();
            BeginContext(462, 20, false);
#line 19 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                      Write(ViewData["id_order"]);

#line default
#line hidden
            EndContext();
            BeginContext(482, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(484, 20, false);
#line 19 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                                            Write(ViewData["sec_code"]);

#line default
#line hidden
            EndContext();
            BeginContext(504, 334, true);
            WriteLiteral(@"',
            type: ""GET"",
            contentType: ""application/json;charset=utf-8"",
            dataType: ""json"",
            success: function (result) {
                var html = '';
                $.each(result, function (key, item) {
                    alert(item)
                    window.location.replace('/Info/");
            EndContext();
            BeginContext(839, 20, false);
#line 27 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                                              Write(ViewData["id_order"]);

#line default
#line hidden
            EndContext();
            BeginContext(859, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(861, 20, false);
#line 27 "D:\Работы\TaxiStation_Core2_EFCore\TaxiStation_Core2_EFCore\Views\Orders\WaitDriver.cshtml"
                                                                    Write(ViewData["sec_code"]);

#line default
#line hidden
            EndContext();
            BeginContext(881, 1631, true);
            WriteLiteral(@"')
                    //html += '<tr>';
                    //html += '<td>' + item.id_client + '</td>';
                    //html += '<td>' + item.rating + '</td>';
                    //var d = new Date(item.date_start_order);
                    //var datestring = ""<b>""+(""0"" + d.getHours()).slice(-2) + "":"" + (""0"" + d.getMinutes()).slice(-2) + ""</b> "" +
                    //    (""0"" + d.getDate()).slice(-2) + ""-"" + (""0"" + (d.getMonth() + 1)).slice(-2) + ""-"" + d.getFullYear();
                    //html += '<td>' + datestring + '</td>';
                    //html += '<td>' + item.order_type_name + '</td>';
                    //html += '<td>' + item.start_point_lat + '</td>';
                    //html += '<td>' + item.start_point_long + '</td>';
                    //html += '<td>' + item.end_point_lat + '</td>';
                    //html += '<td>' + item.end_point_long + '</td>';
                    //html += '<td>' + '<input type=""checkbox"" class=""custom-checkbox"" disabled=""disabled"" ' + ");
            WriteLiteral(@"(item.child?'checked=""checked""':'') + '/>' + '</td>';
                    //html += '<td>' + '<input type=""checkbox"" class=""custom-checkbox"" disabled=""disabled"" ' + (item.pets?'checked=""checked""':'') + '/>' + '</td>';
                    //html += '<td>' + '<a href=""/Order/Accept/' + item.order_id + '"">Принять</a>' + '</td>';
                    //html += '</tr>';
                });
                //$('#tbody_orders').html(html);
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591