#pragma checksum "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89b819043c3e3be857f5f935cb81fbd10cb3723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Otthonbazar.Pages.Advertisements.Pages_Advertisements_Details), @"mvc.1.0.razor-page", @"/Pages/Advertisements/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Advertisements/Details.cshtml", typeof(Otthonbazar.Pages.Advertisements.Pages_Advertisements_Details), null)]
namespace Otthonbazar.Pages.Advertisements
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\_ViewImports.cshtml"
using Otthonbazar;

#line default
#line hidden
#line 3 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\_ViewImports.cshtml"
using Otthonbazar.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89b819043c3e3be857f5f935cb81fbd10cb3723", @"/Pages/Advertisements/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d49b23ba28c601f42b84c5c9fd34007edefaa6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Advertisements_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 127, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Advertisement</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(234, 57, false);
#line 15 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.Address));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 53, false);
#line 18 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.Address));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 67, false);
#line 21 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.AdvertisementType));

#line default
#line hidden
            EndContext();
            BeginContext(499, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(543, 63, false);
#line 24 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.AdvertisementType));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(650, 59, false);
#line 27 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.BuildDate));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(753, 55, false);
#line 30 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.BuildDate));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(852, 54, false);
#line 33 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.City));

#line default
#line hidden
            EndContext();
            BeginContext(906, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(950, 55, false);
#line 36 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.City.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1049, 61, false);
#line 39 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1154, 57, false);
#line 42 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1255, 58, false);
#line 45 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.HalfRoom));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1357, 54, false);
#line 48 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.HalfRoom));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 54, false);
#line 51 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.Room));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1553, 50, false);
#line 54 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.Room));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1647, 58, false);
#line 57 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1749, 54, false);
#line 60 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1847, 55, false);
#line 63 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1946, 51, false);
#line 66 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2041, 54, false);
#line 69 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advertisement.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2139, 50, false);
#line 72 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advertisement.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2236, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df9ef87a241c4751b7570b18facb6562", async() => {
                BeginContext(2296, 4, true);
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
#line 77 "C:\Users\cloud\Desktop\ASP.NET MVC - Startup solution\Otthonbazar\Otthonbazar\Pages\Advertisements\Details.cshtml"
                           WriteLiteral(Model.Advertisement.Id);

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
            BeginContext(2304, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2312, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1928691a9d48948834c4438e146d57", async() => {
                BeginContext(2334, 12, true);
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
            BeginContext(2350, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Otthonbazar.Pages.Advertisements.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Otthonbazar.Pages.Advertisements.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Otthonbazar.Pages.Advertisements.DetailsModel>)PageContext?.ViewData;
        public Otthonbazar.Pages.Advertisements.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
