#pragma checksum "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e66708ee6759ceada4cb42fc10a50a737c8df3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Outbox), @"mvc.1.0.view", @"/Views/Message/Outbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/Outbox.cshtml", typeof(AspNetCore.Views_Message_Outbox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e66708ee6759ceada4cb42fc10a50a737c8df3", @"/Views/Message/Outbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d3ce2afe8ff34448e5c9e3ca13d81aa79cb21a", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Outbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/_Navigation.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
  
Html.RenderPartial("../Shared/_Header.cshtml");

#line default
#line hidden
            BeginContext(56, 94, true);
            WriteLiteral("<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            ");
            EndContext();
            BeginContext(150, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20e66708ee6759ceada4cb42fc10a50a737c8df33728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 402, true);
            WriteLiteral(@"
        </div>
        <div class=""col-9"">
            <div class=""row text-white bg-dark email-list"">
                <div class=""col-3"">
                    Người nhận
                </div>
                <div class=""col-3"">
                    Tiêu đề
                </div>
                <div class=""col-6"">
                    Nội dung
                </div>
            </div>
");
            EndContext();
#line 21 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
             foreach(var item in ViewBag.listOutbox)
            {

#line default
#line hidden
            BeginContext(668, 212, true);
            WriteLiteral("            <div>\r\n                <a class=\"card-link email-hover\">\r\n                    <div class=\"row email-list\">\r\n                        <div class=\"col-3  text-truncate\">\r\n                           Tới: ");
            EndContext();
            BeginContext(881, 17, false);
#line 27 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
                           Write(item.ListReceiver);

#line default
#line hidden
            EndContext();
            BeginContext(898, 122, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-3  text-truncate\">\r\n                            ");
            EndContext();
            BeginContext(1021, 10, false);
#line 30 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 122, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-5  text-truncate\">\r\n                            ");
            EndContext();
            BeginContext(1154, 12, false);
#line 33 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
                       Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 181, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-1\">\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 40 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Outbox.cshtml"
            }

#line default
#line hidden
            BeginContext(1362, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
