using Microsoft.JSInterop;

namespace LandingPage.Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "success", message);
        }

        public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "error", message);
        }
    }
}
