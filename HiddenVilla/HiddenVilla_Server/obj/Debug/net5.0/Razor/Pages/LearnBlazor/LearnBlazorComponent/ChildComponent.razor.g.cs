#pragma checksum "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa2da92ddd94d408dd3e4fba2a3fbe2526b1126"
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
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-info");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
                               Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "alert alert-success");
#nullable restore
#line 7 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
     if (DangerChildContent == null)
    {



        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
         if (ChildContent == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<span>Hello, from Empty Render Fragment</span>");
#nullable restore
#line 15 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "span");
            __builder.AddContent(8, 
#nullable restore
#line 18 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
                   ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "span");
            __builder.AddContent(10, 
#nullable restore
#line 23 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
               DangerChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-danger");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
                                         OnClickBtnMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Button to be clicked!");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.GrandChildComponent>(17);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\ChildComponent.razor"
       
        

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public RenderFragment DangerChildContent { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickBtnMethod { get; set; }

    public async Task ShowSuccessMessage()
    {
        await JSRuntime.ToastrSuccess("ShowSwal", "Parent tarafında tıklandı");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
