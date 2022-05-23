namespace LandingPage.Server.Services.Base
{
    public class BaseHttpService
    {
        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
        {
            if (apiException.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occured.", ValidationErrors = apiException.Response, Success = false };
            }
            if (apiException.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The requested item could not be found.", Success = false };
            }
            if (apiException.StatusCode == 401)
            {
                return new Response<Guid>() { Message = "Invalid Credentials, Please Try Again", Success = false };
            }

            if (apiException.StatusCode >= 200 && apiException.StatusCode <= 299)
            {
                return new Response<Guid>() { Message = "Operation Reported Success", Success = true };
            }

            return new Response<Guid>() { Message = "En uventet feil har oppstått i, vennligst prøv igjen.", Success = false };
        }
    }
}
