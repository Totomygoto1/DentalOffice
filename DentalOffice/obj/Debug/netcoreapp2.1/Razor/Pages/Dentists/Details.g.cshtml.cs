#pragma checksum "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6adedb31e975b1b74c34b61de4de99f790b04501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DentalOffice.Pages.Dentists.Pages_Dentists_Details), @"mvc.1.0.razor-page", @"/Pages/Dentists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Dentists/Details.cshtml", typeof(DentalOffice.Pages.Dentists.Pages_Dentists_Details), null)]
namespace DentalOffice.Pages.Dentists
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6adedb31e975b1b74c34b61de4de99f790b04501", @"/Pages/Dentists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b5c46aaedc9a288250b4c46b0c2252b304909f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dentists_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Dentist</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(223, 53, false);
#line 15 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(320, 49, false);
#line 18 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 52, false);
#line 21 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 48, false);
#line 24 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 50, false);
#line 27 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Street));

#line default
#line hidden
            EndContext();
            BeginContext(651, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(695, 46, false);
#line 30 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Street));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(785, 47, false);
#line 33 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(832, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(876, 43, false);
#line 36 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(963, 48, false);
#line 39 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.City));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1055, 44, false);
#line 42 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.City));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1143, 49, false);
#line 45 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1236, 45, false);
#line 48 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1325, 49, false);
#line 51 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1418, 45, false);
#line 54 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1507, 58, false);
#line 57 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dentist.SocialSecurity));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1609, 54, false);
#line 60 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dentist.SocialSecurity));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1710, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a3955700cc429a962407c6811f7bff", async() => {
                BeginContext(1771, 4, true);
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
#line 65 "C:\Users\katta\source\repos\DentalOffice\DentalOffice\Pages\Dentists\Details.cshtml"
                           WriteLiteral(Model.Dentist.dentistID);

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
            BeginContext(1779, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1787, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe78c1e09c14b238367da9e1ba766e9", async() => {
                BeginContext(1809, 12, true);
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
            BeginContext(1825, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DentalOffice.Pages.Dentists.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DentalOffice.Pages.Dentists.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DentalOffice.Pages.Dentists.DetailsModel>)PageContext?.ViewData;
        public DentalOffice.Pages.Dentists.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
