#pragma checksum "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4035ecbb749d4410bf758dbd3eff75137744d87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Index), @"mvc.1.0.view", @"/Views/Restaurant/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurant/Index.cshtml", typeof(AspNetCore.Views_Restaurant_Index))]
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
#line 1 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\_ViewImports.cshtml"
using RestaurantApp;

#line default
#line hidden
#line 2 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\_ViewImports.cshtml"
using RestaurantApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4035ecbb749d4410bf758dbd3eff75137744d87", @"/Views/Restaurant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9658c3a0f17b607e2e563f86260525d29b9e313", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RestaurantApp.Models.Restaurant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(53, 13, false);
#line 3 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(66, 14, true);
            WriteLiteral("</h1>\r\n\r\n\r\n<p>");
            EndContext();
            BeginContext(80, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c26babfbe3a45d19af0ca3108636cff", async() => {
                BeginContext(128, 14, true);
                WriteLiteral("Add Restaurant");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(146, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(155, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b753e5e61b6d42929d10346d4f22a78b", async() => {
                BeginContext(184, 20, true);
                WriteLiteral("Filter by Categories");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(217, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "998903b3c1ea415fb7f23f6e3ae83801", async() => {
                BeginContext(265, 16, true);
                WriteLiteral("Edit Restaurants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(285, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(320, 31, true);
            WriteLiteral("    <p>No Restaurants Yet</p>\r\n");
            EndContext();
#line 13 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
}

#line default
#line hidden
            BeginContext(354, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 17 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
            BeginContext(387, 126, true);
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Notes</th>\r\n            <th>Type</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
         foreach (var restaurant in Model)
        {

#line default
#line hidden
            BeginContext(568, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(607, 15, false);
#line 29 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
               Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(622, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(650, 16, false);
#line 30 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
               Write(restaurant.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(666, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(694, 24, false);
#line 31 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
               Write(restaurant.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(718, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(755, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(771, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(774, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea7d707500d4a97aa88c03bb003e49a", async() => {
                BeginContext(825, 19, true);
                WriteLiteral("Remove a Restaurant");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(848, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 37 "C:\Users\vjhal\OneDrive\Desktop\Restaurant App\RestaurantApp\RestaurantApp\RestaurantApp\Views\Restaurant\Index.cshtml"
}

#line default
#line hidden
            BeginContext(857, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RestaurantApp.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
