#pragma checksum "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49cb6f91c1a696f3ee43b8cbee7b4e4da4b53a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserDashboard), @"mvc.1.0.view", @"/Views/User/UserDashboard.cshtml")]
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
#line 1 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\_ViewImports.cshtml"
using Jigi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\_ViewImports.cshtml"
using Jigi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49cb6f91c1a696f3ee43b8cbee7b4e4da4b53a9c", @"/Views/User/UserDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb20d48be1db8c9b00013f59f1dae6abed197b9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
  
    ViewData["Title"] = "UserDashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
 if (Model !=null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table-bordered table-striped table-responsive-sm"">
        <thead style=""background-color:darkgray"">
            <tr>
                Name
            </tr>
            <tr>
                Phone Number
            </tr>
            <tr>
                Gender
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
             foreach(var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>");
#nullable restore
#line 31 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
               Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n                <tr>");
#nullable restore
#line 32 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
               Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n                <tr>");
#nullable restore
#line 33 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
               Write(user.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 34 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table> \r\n");
#nullable restore
#line 37 "C:\Users\Lord Fab Marv\Documents\ASP DOTNET CORE PROJECTS\Jigi\Jigi\Views\User\UserDashboard.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
