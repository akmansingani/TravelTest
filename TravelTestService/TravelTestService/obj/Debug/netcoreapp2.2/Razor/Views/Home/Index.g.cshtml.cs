#pragma checksum "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "458b6cf880a7f3c51de691b2725081f292e952b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\_ViewImports.cshtml"
using TravelTestService;

#line default
#line hidden
#line 2 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\_ViewImports.cshtml"
using TravelTestService.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458b6cf880a7f3c51de691b2725081f292e952b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d58c497b4a92a67233138b25ffb10f96b1f81ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelTestService.Models.HotelListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(103, 76, true);
            WriteLiteral("\r\n<div class=\"mb-4\">\r\n    <h1 class=\"display-4 mb-5\">Check Hotels</h1>\r\n    ");
            EndContext();
            BeginContext(179, 829, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "458b6cf880a7f3c51de691b2725081f292e952b64274", async() => {
                BeginContext(199, 57, true);
                WriteLiteral("\r\n\r\n        <div class=\"row mb-2 col-12\">\r\n\r\n            ");
                EndContext();
                BeginContext(257, 389, false);
#line 14 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
       Write(Html.DropDownList("dest", new List<SelectListItem>()
                                     {
                                         new SelectListItem() { Text= "Destination 1", Value = "1" },
                                         new SelectListItem() { Text= "Destination 2", Value = "2" }
                                     }, new { @id = "dest", @class = "form-control m-b" }));

#line default
#line hidden
                EndContext();
                BeginContext(646, 131, true);
                WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"row mb-2 col-12\">\r\n           <input type=\"number\" class=\"form-control\" min=\"1\" id=\"nights\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 777, "\"", 800, 1);
#line 22 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
WriteAttributeValue("", 785, ViewBag.nights, 785, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(801, 200, true);
                WriteLiteral(" name=\"nights\" />\r\n        </div>\r\n        <div class=\"row mb-2 col-12\">\r\n            <button type=\"submit\" name=\"btnSubmit\" class=\"form-control\" id=\"btnSubmit\"> Submit </button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1008, 38, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row mt-4\">\r\n\r\n");
            EndContext();
#line 32 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(1078, 150, true);
            WriteLiteral("        <div class=\"col-lg-12\">\r\n            <div class=\"ibox float-e-margins\">\r\n                <div class=\"ibox-content\">\r\n                       \r\n");
            EndContext();
#line 38 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                 if (Model.Count() > 0)
                                {
                                    foreach (var item in Model)
                                    {
                                        string idName = "oRow" + @item.hotel.propertyID;
                                        

#line default
#line hidden
            BeginContext(1554, 21, true);
            WriteLiteral("<div class=\"row mb-4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1575, "\"", 1587, 1);
#line 43 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
WriteAttributeValue("", 1580, idName, 1580, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 51, true);
            WriteLiteral(">\r\n                                            <h5>");
            EndContext();
            BeginContext(1640, 15, false);
#line 44 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                           Write(item.hotel.name);

#line default
#line hidden
            EndContext();
            BeginContext(1655, 59, true);
            WriteLiteral("</h5> &nbsp;\r\n                                           \r\n");
            EndContext();
#line 46 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                             for(int i = 0;i<item.hotel.rating;i++)
                                            {

#line default
#line hidden
            BeginContext(1846, 71, true);
            WriteLiteral("                                                <span><b>*</b></span>\r\n");
            EndContext();
#line 49 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(1964, 749, true);
            WriteLiteral(@"
                                                <div class=""table-responsive"">
                                                    <table class=""table table-striped"">
                                                        <thead>
                                                            <tr>
                                                                <th>Board Type</th>
                                                                <th>Rate Type</th>
                                                                <th>Value</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
");
            EndContext();
#line 61 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                                             foreach (var subitem in item.rates)
                                                            {


#line default
#line hidden
            BeginContext(2876, 142, true);
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
            EndContext();
            BeginContext(3019, 17, false);
#line 65 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                                                   Write(subitem.boardType);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(3116, 16, false);
#line 66 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                                                   Write(subitem.rateType);

#line default
#line hidden
            EndContext();
            BeginContext(3132, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(3212, 13, false);
#line 67 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                                                   Write(subitem.value);

#line default
#line hidden
            EndContext();
            BeginContext(3225, 78, true);
            WriteLiteral("</td>\r\n                                                                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"



                                                            }

#line default
#line hidden
            BeginContext(3372, 232, true);
            WriteLiteral("                                                        </tbody>\r\n                                                    </table>\r\n                                                </div>\r\n                                        </div>\r\n");
            EndContext();
#line 77 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                    }
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(3789, 209, true);
            WriteLiteral("                                            <div class=\"alert alert-info\">\r\n                                                There are no hotels to display!\r\n                                            </div>\r\n");
            EndContext();
#line 85 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
                                       
                                }

#line default
#line hidden
            BeginContext(4074, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 91 "C:\Users\Paresh\Documents\All docs\Code\github\TravelTest\TravelTestService\TravelTestService\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4143, 18, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelTestService.Models.HotelListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591