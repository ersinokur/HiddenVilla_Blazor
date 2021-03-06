// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelRoom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{id:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Lab\Blazor\HiddenVilla_Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       

    [Parameter]
    public int? Id { get; set; }

    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private HotelRoomImageDTO RoomImage { get; set; } = new HotelRoomImageDTO();
    private List<string> DeleteImageNames { get; set; } = new List<string>();

    private string Title { get; set; } = "Create";
    private bool IsImageUploadProcessStareted { set; get; } = false;

    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationState;
        //  if (!authState.User.Identity.IsAuthenticated)
        if (!authState.User.IsInRole(Common.SD.Role_Admin) )
        {
            var uri = new Uri(NavigateMan.Uri);
            NavigateMan.NavigateTo($"/identity/account/login?returnUrl={uri.LocalPath}");
        }

        if (Id != null)
        {
            //updating
            Title = "Update";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(Id.Value);

            if (HotelRoomModel?.HotelRoomImages != null)
            {
                HotelRoomModel.ImageUrls = HotelRoomModel.HotelRoomImages.Select(u => u.RoomImageUrl).ToList();
            }

        }
        else
        {
            //create
            HotelRoomModel = new HotelRoomDTO();

        }


    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;

        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(HotelRoomModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
                }
                loading = false;
            }
            catch (Exception)
            {

                await Task.Delay(10);
                loading = true;
            }
        }


        //return base.OnAfterRenderAsync(firstRender);
    }

    private async Task HandleHotelRoomUpsert()
    {

        try
        {
            var roomDetailsByName = await HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name, HotelRoomModel.Id);
            if (roomDetailsByName != null)
            {
                //there is duplicate room show error
                await JSRuntime.ToastrError("ShowSwal", "Room name already exists!");
                return;
            }

            if (HotelRoomModel.Id != 0 && Title == "Update")
            {
                //update
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                var updatedRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);

                if ((HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    || DeleteImageNames != null && DeleteImageNames.Any()
                    )
                {

                    if (DeleteImageNames != null && DeleteImageNames.Any())
                    {
                        foreach (var deletedImageName in DeleteImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigateMan.BaseUri}RoomImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await HotelRoomImagesRepository.DeleteHotelRoomImagebyImageUrl(deletedImageName);

                        }
                    }

                    await AddHotelRoomImage(updatedRoomResult);
                }
                await JSRuntime.ToastrSuccess("ShowSwal", "hotel room updated succesfully");
            }
            else
            {
                //create
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await AddHotelRoomImage(createdResult);

                await JSRuntime.ToastrSuccess("ShowSwal", "hotel room created succesfully");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
        }

        //HotelRoomModel.Details = "Button clicked";

        NavigateMan.NavigateTo("hotel-room");

    }

    private async Task HandeImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStareted = true;
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg"
                        )
                    {
                        var uploadedImagePath = await FileUpload.Uploadfile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JSRuntime.ToastrError("ShowSwal", "Please select .jpg / .jpeg  /.png file only");
                        return;
                    }

                }

                if (images.Any())
                {
                    if (HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    {
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        HotelRoomModel.ImageUrls = new List<string>();
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JSRuntime.ToastrError("ShowSwal", "Image uploading failed!");
                    return;
                }
            }
            IsImageUploadProcessStareted = false;
        }
        catch (Exception ex)
        {
            //log exceptions
            await JSRuntime.ToastrError("ShowSwal", ex.Message);
        }
    }
    private async Task AddHotelRoomImage(HotelRoomDTO roomDetails)
    {
        foreach (var imageUrl in HotelRoomModel.ImageUrls)
        {

            if (HotelRoomModel.HotelRoomImages == null || HotelRoomModel.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
            {

                RoomImage = new HotelRoomImageDTO()
                {
                    RoomId = roomDetails.Id,
                    RoomImageUrl = imageUrl

                };
                await HotelRoomImagesRepository.CreateHotelRoomImage(RoomImage);
            }
        }
    }

    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = HotelRoomModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigateMan.BaseUri}RoomImages/", "");
            if (HotelRoomModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //upadate
                DeleteImageNames ??= new List<string>();
                DeleteImageNames.Add(imageUrl);
            }
            HotelRoomModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            //log exceptions
            await JSRuntime.ToastrError("ShowSwal", ex.Message);
        }
    }

    //public  void SetHTML()
    //{
    //    if (!string.IsNullOrEmpty(HotelRoomModel.Details))
    //    {
    //         this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);

    //    }
    //    StateHasChanged();
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigateMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomImagesRepository HotelRoomImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
