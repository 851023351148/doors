#pragma checksum "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/Account/ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5c4d538120221267bf235366b888dd366a5b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(bowerMiniCRM.Pages.Account.Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Pages/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/ForgotPasswordConfirmation.cshtml", typeof(bowerMiniCRM.Pages.Account.Pages_Account_ForgotPasswordConfirmation), null)]
namespace bowerMiniCRM.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/_ViewImports.cshtml"
using bowerMiniCRM;

#line default
#line hidden
#line 3 "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/_ViewImports.cshtml"
using bowerMiniCRM.Data;

#line default
#line hidden
#line 1 "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/Account/_ViewImports.cshtml"
using bowerMiniCRM.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5c4d538120221267bf235366b888dd366a5b83", @"/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64fd8185ec094a503d39704167fe5736a93b1a6", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d0671b41f26b0cc06a966edc6bf258e7f43fef", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/mnt/d/Projects/bowerMiniCRM/bowerMiniCRM/Pages/Account/ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Reset confirmation";

#line default
#line hidden
            BeginContext(101, 155, true);
            WriteLiteral("\r\n<div class=\"login-box-body\">\r\n    <p class=\"login-box-msg\">Please check your email to reset your password.</p>\r\n</div>\r\n<!-- /.login-box-body -->\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmationModel>)PageContext?.ViewData;
        public ForgotPasswordConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
