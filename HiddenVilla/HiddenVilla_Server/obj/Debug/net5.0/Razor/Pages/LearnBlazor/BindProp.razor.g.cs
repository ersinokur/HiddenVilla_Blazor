#pragma checksum "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c56b3b9ea7d370cd4fc71209b7ea0b9122edaa9"
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
#nullable restore
#line 2 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindprompt")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "border");
            __builder.AddAttribute(3, "p-2");
            __builder.AddMarkupContent(4, "<h2 class=\"bg-light border p2-2\">First Room</h2>\r\n    Room: ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
           Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n    Price: ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
            Room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                       Room.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.Price = __value, Room.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    <br>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "checkbox");
            __builder.AddAttribute(16, "checked", 
#nullable restore
#line 13 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                   Room.IsActive ? "Checked" : null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                         Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, " &nbsp; Is Active\r\n    <br>\r\n    ");
            __builder.OpenElement(20, "span");
            __builder.AddContent(21, "This Room is ");
            __builder.AddContent(22, 
#nullable restore
#line 15 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         Room.IsActive ? "Active" : "Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    <br>\r\n    ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRoomProp = __value, SelectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 18 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach (var prop in Room.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 20 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                            prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, 
#nullable restore
#line 20 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, "The Room Prop selected: ");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "div");
            __builder.AddMarkupContent(37, "<br>\r\n    ");
            __builder.AddMarkupContent(38, "<h2 class=\"text-info\">Room List [Assigment 2]</h2>\r\n    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-dark");
#nullable restore
#line 31 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach (var room in Rooms)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                 foreach (var roomProp in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 42 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " - ");
            __builder.AddContent(56, 
#nullable restore
#line 42 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                          roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n    <br>");
#nullable restore
#line 50 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
     foreach (var room in Rooms)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "p");
            __builder.AddContent(59, 
#nullable restore
#line 52 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
            room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, "\'s Price is ");
            __builder.AddContent(61, 
#nullable restore
#line 52 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                      room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
       

    string SelectedRoomProp = "";
    List<BlazorRoom> Rooms = new List<BlazorRoom>();

    BlazorRoom Room = new BlazorRoom
    {
        Id = 201,
        RoomName = "Villa Suite",
        IsActive = true,
        Price = 499,
        RoomProps = new List<BlazorRoomProp>
    {
            new BlazorRoomProp { Id = 1, Name = "Sq ft", Value = "330" },
            new BlazorRoomProp{Id=1, Name="Occupancy", Value="4" },
        }
    };


    protected override void OnInitialized()
    {
        Rooms.Add(new BlazorRoom()
        {
            Id = 201,
            RoomName = "Villa Suite",
            IsActive = true,
            Price = 499,
            RoomProps = new List<BlazorRoomProp>
 {
                        new BlazorRoomProp { Id = 1, Name = "Sq ft", Value = "330" },
                        new BlazorRoomProp{Id=1, Name="Occupancy", Value="4" },
                      }

        });

        Rooms.Add(new BlazorRoom()
        {
            Id = 301,
            RoomName = "Villa Suite two bed room",
            IsActive = true,
            Price = 699,
            RoomProps = new List<BlazorRoomProp>
 {  
                        new BlazorRoomProp { Id = 1, Name = "Sq ft", Value = "630" },
                        new BlazorRoomProp{Id=1, Name="Occupancy", Value="6" },
                      }

        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
