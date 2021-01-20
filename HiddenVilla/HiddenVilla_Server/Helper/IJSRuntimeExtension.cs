using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string funcName,string message)
        {
            //geriye birsey donmezse InvokeVoidAsync
            //ShowToastr --> www>js>common.js de tanimadiğim metod adi!
            //success --> www>js>common.js de type adi
            await JSRuntime.InvokeVoidAsync(funcName, "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime JSRuntime, string funcName, string message)
        {
            //geriye birsey donmezse InvokeVoidAsync
            //ShowToastr --> www>js>common.js de tanimadiğim metod adi!
            //success --> www>js>common.js de type adi
            await JSRuntime.InvokeVoidAsync(funcName, "error", message);
        }
    }
}