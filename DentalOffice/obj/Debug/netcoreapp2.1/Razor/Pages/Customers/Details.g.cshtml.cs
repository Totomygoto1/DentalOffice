#pragma checksum "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08beaf164459c48ed09f055151e575f3c2b4e4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DentalOffice.Pages.Customers.Pages_Customers_Details), @"mvc.1.0.razor-page", @"/Pages/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Customers/Details.cshtml", typeof(DentalOffice.Pages.Customers.Pages_Customers_Details), null)]
namespace DentalOffice.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\_ViewImports.cshtml"
using DentalOffice;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08beaf164459c48ed09f055151e575f3c2b4e4a", @"/Pages/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b5c46aaedc9a288250b4c46b0c2252b304909f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 54, false);
#line 15 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 50, false);
#line 18 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 53, false);
#line 21 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 49, false);
#line 24 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(607, 51, false);
#line 27 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Street));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 47, false);
#line 30 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Street));

#line default
#line hidden
            EndContext();
            BeginContext(749, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(793, 48, false);
#line 33 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(841, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(885, 44, false);
#line 36 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(973, 49, false);
#line 39 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.City));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1066, 45, false);
#line 42 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.City));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1155, 50, false);
#line 45 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1249, 46, false);
#line 48 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1339, 50, false);
#line 51 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1433, 46, false);
#line 54 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1523, 59, false);
#line 57 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.SocialSecurity));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1626, 55, false);
#line 60 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.SocialSecurity));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1728, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdefa1c953a848e78fecfafa041031ad", async() => {
                BeginContext(1791, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Customers\Details.cshtml"
                           WriteLiteral(Model.Customer.customerID);

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
            BeginContext(1799, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1807, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04d87bcd22d4daeb618bd07848bc350", async() => {
                BeginContext(1829, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1845, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DentalOffice.Pages.Customers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DentalOffice.Pages.Customers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DentalOffice.Pages.Customers.DetailsModel>)PageContext?.ViewData;
        public DentalOffice.Pages.Customers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
