#pragma checksum "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4646a295aec9a2835dfca206dc9db3c686a1073c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Inbox), @"mvc.1.0.view", @"/Views/Home/Inbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Inbox.cshtml", typeof(AspNetCore.Views_Home_Inbox))]
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
#line 1 "/Users/Palif/Projects/CommunityDotnet/Views/_ViewImports.cshtml"
using CommunityDotnet;

#line default
#line hidden
#line 2 "/Users/Palif/Projects/CommunityDotnet/Views/_ViewImports.cshtml"
using CommunityDotnet.Models;

#line default
#line hidden
#line 3 "/Users/Palif/Projects/CommunityDotnet/Views/_ViewImports.cshtml"
using CommunityDotnet.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4646a295aec9a2835dfca206dc9db3c686a1073c", @"/Views/Home/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"504b2256e15df99e60f6b4eadbf3046a2bf955e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InboxViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 50, true);
            WriteLiteral("\r\n<h1> Inbox </h1>\r\n\r\n<div>\r\n    Nr of messages : ");
            EndContext();
            BeginContext(74, 47, false);
#line 6 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
                Write(Html.DisplayFor(model=> model.NumberOfMessages));

#line default
#line hidden
            EndContext();
            BeginContext(121, 25, true);
            WriteLiteral(", Nr of unread message : ");
            EndContext();
            BeginContext(147, 51, false);
#line 6 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
                                                                                         Write(Html.DisplayFor(model=>model.NumberOfUnreadMessage));

#line default
#line hidden
            EndContext();
            BeginContext(198, 52, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h3> Senders </h3>\r\n<div>\r\n    <table>\r\n");
            EndContext();
#line 12 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
         foreach (var user in Model.AllSenderViewModel)
        {

#line default
#line hidden
            BeginContext(318, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(357, 43, false);
#line 15 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
               Write(Html.DisplayFor(modelitem => user.Username));

#line default
#line hidden
            EndContext();
            BeginContext(400, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(428, 76, false);
#line 16 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
               Write(Html.ActionLink("Select", "InboxSender", "Home", new { id = user.Username }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 18 "/Users/Palif/Projects/CommunityDotnet/Views/Home/Inbox.cshtml"
        }

#line default
#line hidden
            BeginContext(541, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InboxViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
