#pragma checksum "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f169c5008b8fc1fab134d44dabc575b33bce5fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\_ViewImports.cshtml"
using UserManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\_ViewImports.cshtml"
using UserManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
using UserManagementSystem.Model.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f169c5008b8fc1fab134d44dabc575b33bce5fe4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668b74540c613d99683068dde6b86525d46633c7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserManagementSystem.Model.DTOModels.UserEditDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/userJavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>User List</h3>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("Email Address"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("Phone Number"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
           Write(Html.Label("Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 51 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                     if (User.IsInRole("ADMIN"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                                                                              
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 58 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                     if (User.IsInRole("ADMIN"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-danger Delete\" data-id=\"");
#nullable restore
#line 60 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n");
#nullable restore
#line 61 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<br />
<a href=""/User/Register"" class=""btn btn-primary"">Add User</a>

<div id=""DeleteModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete Confirmation</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""body"" class=""modal-body"">
                <p>Are you sure to delete?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""DeleteButton"" class=""btn btn-danger"">Delete</button>
                <button type=""button""  class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f169c5008b8fc1fab134d44dabc575b33bce5fe411545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserManagementSystem.Model.DTOModels.UserEditDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
