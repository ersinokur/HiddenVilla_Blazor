#pragma checksum "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7bebd215e745a0351276b48ff04b4b106ea93bf"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoHotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DemoHotel</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border p-2 mt-2");
            __builder.AddAttribute(3, "style", "background-color:azure");
            __builder.AddMarkupContent(4, "<h2 class=\"text-info\">Room List [Using Component] </h2>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row container");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.AddMarkupContent(9, "<h4 class=\"text-info\"> Hotel Room\'s</h4>\r\n            ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, " Rooms Selected: ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                    SelectedRooms

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
         foreach (var room in Rooms)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.IndividualRoom>(13);
            __builder.AddAttribute(14, "Room", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HiddenVilla_Server.Model.BlazorRoom>(
#nullable restore
#line 16 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                  room

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnRoomCheckBoxSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 16 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                RoomSelectionCounterChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<div class=\"col-12 mt-4\"><h4 class=\"text-info\"> Hotel Amenties\'s [assigment] </h4></div>");
#nullable restore
#line 24 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
         foreach (var amenity in Amenities)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.IndividualAminities>(17);
            __builder.AddAttribute(18, "Amenity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HiddenVilla_Server.Model.BlazorAmenities>(
#nullable restore
#line 26 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                           amenity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnAmenitySelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 26 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                                         AmenitySelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "FirstFragment", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, "#1");
            }
            ));
            __builder.AddAttribute(22, "SecondFragment", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "#2");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-12");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "text-secondary");
            __builder.AddContent(29, " Selected Amenity : ");
            __builder.AddContent(30, 
#nullable restore
#line 36 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
                                                       SelectedAmentiy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\lab\Blazor\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
       

    public int SelectedRooms { get; set; } = 0;
    public string SelectedAmentiy { get; set; }

    List<BlazorRoom> Rooms = new List<BlazorRoom>();
    List<BlazorAmenities> Amenities = new List<BlazorAmenities>();


    protected override void OnInitialized()
    {

        GetRooms();
        GetAminities();
    }

    void GetRooms()
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
            IsActive = false,
            Price = 699,
            RoomProps = new List<BlazorRoomProp>
{
                        new BlazorRoomProp { Id = 1, Name = "Sq ft", Value = "630" },
                        new BlazorRoomProp{Id=1, Name="Occupancy", Value="6" },
                      }

        });
    }
    void GetAminities()
    {
        Amenities.Add(new BlazorAmenities
        {
            Id = 111,
            Name = "Gym",
            Description = "24x7 gym room is available"
        });

        Amenities.Add(new BlazorAmenities
        {
            Id = 222,
            Name = "Swimming Pool",
            Description = "Pool room is open from 6am to 10pm."
        });
        Amenities.Add(new BlazorAmenities
        {
            Id = 333,
            Name = "Free Breakfast",
            Description = "Enjoy free breakfast at out hotel."
        });
    }

    protected void RoomSelectionCounterChanged(bool isRoomSelected)
    {
        //SelectedRooms = isRoomSelected ? SelectedRooms++ : SelectedRooms--;

        if (isRoomSelected)
        {
            SelectedRooms++;
        }
        else
        {
            SelectedRooms--;
        }
    }


    protected void AmenitySelectionChanged(string amenity)
    {
        SelectedAmentiy = amenity;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
