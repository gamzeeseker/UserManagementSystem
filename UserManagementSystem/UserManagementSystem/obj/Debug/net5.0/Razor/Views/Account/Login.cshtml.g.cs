#pragma checksum "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4159e9b857f2432a5ccc0ec867f973aa90b2ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4159e9b857f2432a5ccc0ec867f973aa90b2ca", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668b74540c613d99683068dde6b86525d46633c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserManagementSystem.Model.DTOModels.LoginDto>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4159e9b857f2432a5ccc0ec867f973aa90b2ca4025", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type=""text/javascript"" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel=""stylesheet"" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
          media=""screen"" />

");
#nullable restore
#line 32 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
     using (Html.BeginForm("Login", "Account", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"offset-md-3 col-md-4\">\r\n            </div>\r\n\r\n            <div class=\"offset-md-3 col-md-4\">\r\n                <h2 class=\"form-signin-heading\">\r\n                    Login\r\n                </h2>\r\n");
#nullable restore
#line 42 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
                 if (!string.IsNullOrWhiteSpace(ViewBag.ErrorMessage))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n\r\n                        ");
#nullable restore
#line 46 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
                   Write(Html.Display("ErrorMessage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
#nullable restore
#line 50 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
           Write(Html.Label("User Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 51 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 53 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n                ");
#nullable restore
#line 56 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
           Write(Html.Label("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 59 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "error" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"checkbox\">\r\n                    ");
#nullable restore
#line 62 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.RememberMe, new { @for = "Remember Me" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
               Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
                WriteLiteral(@"                <br />
                <input type=""submit"" value=""Submit"" class=""btn btn-primary"" />
                <br />
                <br />
                <div id=""dvMessage"" class=""alert alert-danger hide"">
                    <strong>Error!</strong>
                    <span>");
#nullable restore
#line 72 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
                     Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 76 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
     if (@ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\r\n            $(function () {\r\n                $(\"#dvMessage\").show();\r\n            });\r\n        </script>\r\n");
#nullable restore
#line 85 "C:\GitHubRepositories\UserManagement\UserManagementSystem\UserManagementSystem\UserManagementSystem\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserManagementSystem.Model.DTOModels.LoginDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
