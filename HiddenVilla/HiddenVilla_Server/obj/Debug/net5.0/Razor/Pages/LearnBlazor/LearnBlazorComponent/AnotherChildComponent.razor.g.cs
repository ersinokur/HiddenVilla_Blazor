#pragma checksum "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7701c7c358990e1b5fc44af55ef967b633fdac5d"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Models.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Service.IServices;

#line default
#line hidden
#nullable disable
    public partial class AnotherChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4 class=\"text-primary pt-3\">Another Child Component</h4>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "id", "RoomName");
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor"
                                   InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor"
       

    //[Parameter]
    //public string PlaceHolder { get; set; }

    [Parameter]
    public Dictionary<string, object> InputAttributes { get; set; }  = new Dictionary<string, object>()
    {
        {"required" , "required" },
        {"placeholder" , "Initial Text" },
        {"maxlength" , 10 },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
