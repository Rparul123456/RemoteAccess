#pragma checksum "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e341f10491f2beba553e0d29ded29d59a927f809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RemoteServerDetails_RemoteServerDetails), @"mvc.1.0.view", @"/Views/RemoteServerDetails/RemoteServerDetails.cshtml")]
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
#line 1 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\_ViewImports.cshtml"
using RemoteServerAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\_ViewImports.cshtml"
using RemoteServerAccess.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e341f10491f2beba553e0d29ded29d59a927f809", @"/Views/RemoteServerDetails/RemoteServerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c8c703dbd3f0d312d4701dbbe94fbc5ede8d2d", @"/Views/_ViewImports.cshtml")]
    public class Views_RemoteServerDetails_RemoteServerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RemoteServerAccess.Models.RemoteServerDetails.RSDetails>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
  
    ViewData["Title"] = "RemoteServerDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>RemoteServerDetails</h2>\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e341f10491f2beba553e0d29ded29d59a927f8093731", async() => {
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e341f10491f2beba553e0d29ded29d59a927f8095252", async() => {
                WriteLiteral(@"

    

    <div class=""container"">
        <table class=""table table-dark table-hover"">
            <thead>
                <tr>
                    <th>Server Name</th>
                    <th>User S</th>
                    <th>User P</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
                 foreach (var items in Model)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
                   Write(items.ServerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        Occupied By : ");
#nullable restore
#line 39 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
                                 Write(items.USER_S_ACCESS_BY);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <button>Released</button>\r\n                    </td>\r\n                    <td>\r\n                        Occupied By : ");
#nullable restore
#line 43 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
                                 Write(items.USER_P_ACCESS_BY);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <button>Take Access</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\chourpar\source\repos\RemoteServerAccess\Views\RemoteServerDetails\RemoteServerDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RemoteServerAccess.Models.RemoteServerDetails.RSDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
