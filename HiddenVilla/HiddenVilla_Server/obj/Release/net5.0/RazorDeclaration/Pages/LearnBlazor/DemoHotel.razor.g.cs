// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoHotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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