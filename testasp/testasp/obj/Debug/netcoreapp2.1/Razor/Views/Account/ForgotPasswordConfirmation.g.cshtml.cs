#pragma checksum "C:\Users\sankalpg\source\repos\testasp\testasp\Views\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf4c5ba6e3ca4a8724daa3f85bef61694575ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ForgotPasswordConfirmation.cshtml", typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation))]
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
#line 1 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\_ViewImports.cshtml"
using testasp;

#line default
#line hidden
#line 2 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\_ViewImports.cshtml"
using testasp.Models;

#line default
#line hidden
#line 3 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\_ViewImports.cshtml"
using testasp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\_ViewImports.cshtml"
using testasp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf4c5ba6e3ca4a8724daa3f85bef61694575ddb", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf96c6f201560805932ac43058479c276d14f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot Password Confirmation";

#line default
#line hidden
            BeginContext(61, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(67, 17, false);
#line 5 "C:\Users\sankalpg\source\repos\testasp\testasp\Views\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(84, 68, true);
            WriteLiteral(".</h2>\n<p>\n    Please check your email to reset your password.\n</p>\n");
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
