#pragma checksum "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1567f5e57be3eee8065e4219ae5d218537a31b1d"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Models.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Service.IServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 3 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Shared\LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddMarkupContent(5, "<a href=\"/Identity/Account/Logout\">Logout</a>");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<a href=\"/Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(8, "<a href=\"/Identity/Account/Login\">Login</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591