#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3058d95945fd88203a435a02a89b48df8ce09a54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
#line 1 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.Models.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.Models.Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.ViewModels.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.DataLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3058d95945fd88203a435a02a89b48df8ce09a54", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a916f667fdf56790448e03f4552a10a50e5d6e19", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Invoice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition register-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3058d95945fd88203a435a02a89b48df8ce09a544706", async() => {
                WriteLiteral(@"
    <div class=""row justify-content-center"">
        <div class=""col-sm-12"">
            <div class=""register-box"">
                <div class=""card"">
                    <div class=""card-body register-card-body"">

                        <p class=""login-box-msg""><b>Invoice History</b></p>
                        
");
#nullable restore
#line 17 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                         if(Model.Count()>0)
                        { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <table class=\"table\">\r\n                            <thead>\r\n                                <tr>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 23 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.InvoiceId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 26 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 29 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 32 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </th>
                                    <th>
                                        Actions
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 40 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 44 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.InvoiceId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 47 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(item.OrderDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 50 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 53 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(item.Total.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.ActionLink("Pay", "PayInvoce", new { id = item.InvoiceId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                                        ");
#nullable restore
#line 57 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { id = item.InvoiceId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n");
                WriteLiteral("                                        <a class=\"btn btn-danger delete\" data-id=\"");
#nullable restore
#line 59 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                                                             Write(item.InvoiceId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" data-controller=""invoice"" data-action=""delete"" data-body-message=""Are you sure?"">
                                            <i class=""fas fa-trash alt""></i>
                                            Delete
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 65 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 68 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                        }
                        else {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <h5>You have no invoices so far ...</h5>");
#nullable restore
#line 69 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Index.cshtml"
                                                                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
