#pragma checksum "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2353ed9014aae20f2a591cc1d758636a9ee13993"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/blazorjs")]
    public partial class BlazorJS : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlazorJS</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-secondary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                                ()=>TestConfirmBox(ConfirmMesssage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Test Cofirm Button ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row mt-4");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                              TestToasterSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Test Cofirm Button ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    <br>\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-danger");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                             TestToasterError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Test Cofirm Button ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row mt-4");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-success");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                              TestSwalSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Test SweetAlerJS Success ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    <br>\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                             TestSwalError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Test SweetAlerJS Success ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
#nullable restore
#line 24 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
     if (ConfirmResult)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<p>Confirmation has been made!</p>");
#nullable restore
#line 27 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p>Confirmation Pending!</p>");
#nullable restore
#line 31 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
       

    private string ConfirmMesssage = "Are you sure you want to click?";
    private bool ConfirmResult { get; set; }

    private async Task TestConfirmBox(string message)
    {
        //Geriye birsey donerse; InvokeAsync
        ConfirmResult = await JSRuntime.InvokeAsync<bool>("confirm", ConfirmMesssage);
    }

    private async Task TestToasterSuccess()
    {

        await JSRuntime.ToastrSuccess("ShowToastr","işlem başarılı");
    }

    private async Task TestToasterError()
    {

        await JSRuntime.ToastrError("ShowToastr", "Bir hata oluştu");
    }
    private async Task TestSwalSuccess()
    {
        //extensiona gerek kalmadan dogrudan cagirimi
        //await JSRuntime.InvokeVoidAsync("ShowSwal", "success", "Task completed successfully");
        await JSRuntime.ToastrSuccess("ShowSwal", "Task completed successfully");

    }

    private async Task TestSwalError()
    {

        //await JSRuntime.InvokeVoidAsync("ShowSwal", "error", "Task failed");
        await JSRuntime.ToastrError("ShowSwal", "Task Failed");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
