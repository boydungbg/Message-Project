#pragma checksum "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "357f17d0dfdf36b4b969916c21c062315588304b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Inbox), @"mvc.1.0.view", @"/Views/Message/Inbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/Inbox.cshtml", typeof(AspNetCore.Views_Message_Inbox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"357f17d0dfdf36b4b969916c21c062315588304b", @"/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d3ce2afe8ff34448e5c9e3ca13d81aa79cb21a", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/_Navigation.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/rubbish-bin-delete-button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("16px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("16px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
  
Html.RenderPartial("../Shared/_Header.cshtml");

#line default
#line hidden
            BeginContext(56, 94, true);
            WriteLiteral("<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            ");
            EndContext();
            BeginContext(150, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "357f17d0dfdf36b4b969916c21c062315588304b5277", async() => {
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
            BeginContext(197, 401, true);
            WriteLiteral(@"
        </div>
        <div class=""col-9"">
            <div class=""row text-white bg-dark email-list"">
                <div class=""col-3"">
                    Người gửi
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
#line 21 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
             foreach(var item in ViewBag.listInbox)
            {
            

#line default
#line hidden
#line 23 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
             if(item.StatusMessage == 0)
            {

#line default
#line hidden
            BeginContext(723, 91, true);
            WriteLiteral("            <div class=\"row email-list\">\r\n                <div class=\"col-3  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 814, "\"", 922, 3);
            WriteAttributeValue("", 845, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 845, 61, true);
#line 27 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 906, item.MessageID, 906, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 921, "\'", 921, 1, true);
            EndWriteAttribute();
            BeginContext(923, 26, true);
            WriteLiteral(">\r\n                    <b>");
            EndContext();
            BeginContext(950, 28, false);
#line 28 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
                  Write(item.Message.Sender.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(978, 79, true);
            WriteLiteral("</b>\r\n                </div>\r\n                <div class=\"col-3  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 1057, "\"", 1165, 3);
            WriteAttributeValue("", 1088, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 1088, 61, true);
#line 31 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 1149, item.MessageID, 1149, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1164, "\'", 1164, 1, true);
            EndWriteAttribute();
            BeginContext(1166, 27, true);
            WriteLiteral(">\r\n                    <b> ");
            EndContext();
            BeginContext(1194, 18, false);
#line 32 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
                   Write(item.Message.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 79, true);
            WriteLiteral("</b>\r\n                </div>\r\n                <div class=\"col-5  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 1291, "\"", 1399, 3);
            WriteAttributeValue("", 1322, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 1322, 61, true);
#line 35 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 1383, item.MessageID, 1383, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1398, "\'", 1398, 1, true);
            EndWriteAttribute();
            BeginContext(1400, 27, true);
            WriteLiteral(">\r\n                    <b> ");
            EndContext();
            BeginContext(1428, 20, false);
#line 36 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
                   Write(item.Message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1448, 106, true);
            WriteLiteral("</b>\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    <button class=\"bin\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                        onclick=\"", 1554, "\"", 1665, 3);
            WriteAttributeValue("", 1589, "window.location.href=\'/Message/DeleteMessageInbox?MessageID=", 1589, 60, true);
#line 40 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 1649, item.MessageID, 1649, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1664, "\'", 1664, 1, true);
            EndWriteAttribute();
            BeginContext(1666, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1693, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "357f17d0dfdf36b4b969916c21c062315588304b11274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1773, 77, true);
            WriteLiteral("\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 45 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
            }

#line default
#line hidden
#line 46 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
             if(item.StatusMessage == 1)
            {

#line default
#line hidden
            BeginContext(1922, 128, true);
            WriteLiteral("            <div class=\"row email-list\" style=\"background-color: whitesmoke\">\r\n                <div class=\"col-3  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 2050, "\"", 2158, 3);
            WriteAttributeValue("", 2081, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 2081, 61, true);
#line 50 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 2142, item.MessageID, 2142, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2157, "\'", 2157, 1, true);
            EndWriteAttribute();
            BeginContext(2159, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2183, 28, false);
#line 51 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
               Write(item.Message.Sender.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2211, 75, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-3  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 2286, "\"", 2394, 3);
            WriteAttributeValue("", 2317, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 2317, 61, true);
#line 54 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 2378, item.MessageID, 2378, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2393, "\'", 2393, 1, true);
            EndWriteAttribute();
            BeginContext(2395, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2419, 18, false);
#line 55 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
               Write(item.Message.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2437, 75, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-5  text-truncate\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 2512, "\"", 2620, 3);
            WriteAttributeValue("", 2543, "window.location.href=\'/Message/UpdateStatusMessage?messageID=", 2543, 61, true);
#line 58 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 2604, item.MessageID, 2604, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2619, "\'", 2619, 1, true);
            EndWriteAttribute();
            BeginContext(2621, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2645, 20, false);
#line 59 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
               Write(item.Message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2665, 102, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    <button class=\"bin\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                        onclick=\"", 2767, "\"", 2878, 3);
            WriteAttributeValue("", 2802, "window.location.href=\'/Message/DeleteMessageInbox?MessageID=", 2802, 60, true);
#line 63 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 2862, item.MessageID, 2862, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2877, "\'", 2877, 1, true);
            EndWriteAttribute();
            BeginContext(2879, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(2906, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "357f17d0dfdf36b4b969916c21c062315588304b17060", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2986, 77, true);
            WriteLiteral("\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 68 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
            }

#line default
#line hidden
#line 68 "D:\PROGRAMER\Homework\Project-Email\Views\Message\Inbox.cshtml"
             
            }

#line default
#line hidden
            BeginContext(3093, 34, true);
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
