#pragma checksum "D:\PROGRAMER\Homework\Project-Email\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d86b2e1ab89295e6d5b67747661a7836735158c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "D:\PROGRAMER\Homework\Project-Email\Views\_ViewImports.cshtml"
using Project_Email;

#line default
#line hidden
#line 2 "D:\PROGRAMER\Homework\Project-Email\Views\_ViewImports.cshtml"
using Project_Email.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d86b2e1ab89295e6d5b67747661a7836735158c", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d3ce2afe8ff34448e5c9e3ca13d81aa79cb21a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 235, true);
            WriteLiteral("<div class=\"header\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <nav class=\"navbar navbar-expand-lg navbar-dark\">\r\n                    <div class=\"navbar-brand\">Xin chào, ");
            EndContext();
            BeginContext(236, 12, false);
#line 6 "D:\PROGRAMER\Homework\Project-Email\Views\Shared\_Header.cshtml"
                                                   Write(ViewBag.user);

#line default
#line hidden
            EndContext();
            BeginContext(248, 855, true);
            WriteLiteral(@" </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav""
                        aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse "" id=""navbarNav"">
                        <ul class=""navbar-nav ml-auto"">
                            <li class=""nav-item active"">
                                <a href=""/User/Logout""><button type=""button"" class=""btn btn-success"">Đăng
                                        xuất</button></a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </div>
        </div>
    </div>
</div>");
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
