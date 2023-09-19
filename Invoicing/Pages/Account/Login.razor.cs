using Microsoft.AspNetCore.Components;
using Invoicing.DAL.ViewModels;

namespace Invoicing.Pages.Account
{
    public partial class Login
    {
        public LoginVM logInRequest { get; set; } = new();

        public async void SubmitLoginRequest()
        {
            //   var result = accountService.Login(logInRequest);
            // _response = result.Result;
            //if (_response.IsLoginSuccess)
            //{
            //    var tokenStr = _response.Token;
            //    _localStorage.SetItemAsync("jwt_token", tokenStr);
            //    _localStorage.SetItemAsync("EpOrgId", _response.EpOrgId);
            //    NavigationManager.NavigateTo("/EventOrganizer/Dashboard");
            //}
            //else
            //    Console.WriteLine("Some thing went wrong, " + string.Join(", ", _response.ErrorMessages));
            //var token = _response.Token;
        }

    }
}
