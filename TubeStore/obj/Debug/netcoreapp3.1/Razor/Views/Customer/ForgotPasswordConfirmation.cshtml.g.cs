#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Views\Customer\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deea7f4c312f2d922930ee95279771d9e30f2c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Customer/ForgotPasswordConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deea7f4c312f2d922930ee95279771d9e30f2c3a", @"/Views/Customer/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a916f667fdf56790448e03f4552a10a50e5d6e19", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\Repos\05 - TubeStore\TubeStore\Views\Customer\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "d:\Repos\05 - TubeStore\TubeStore\Views\Customer\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>\r\n");
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
