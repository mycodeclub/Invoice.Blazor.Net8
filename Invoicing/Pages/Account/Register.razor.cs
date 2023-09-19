using Azure;
using Invoicing.DAL.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Invoicing.Pages.Account
{
    public partial class Register : ComponentBase
    {
        protected NavigationManager NavigationManager { get; set; }

        [SupplyParameterFromForm]
        public  UserRegistrationVM UserRegistrationRequest { get; set; } = new UserRegistrationVM();

        EditForm? editForm;
        
        //public UserRegistrationVM UserRegistrationRequest { get; set; }

        //protected override void OnInitialized()
        //{
        //    UserRegistrationRequest ??= new();
        //    base.OnInitialized();
        //}

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public void SubmitUserRegistration()
        {


            var name = UserRegistrationRequest.Name;
        }


        private async Task SubmitRegistrationForm()
        {
            var name = UserRegistrationRequest.Name;
        }

        private async Task ValidRegistrationFormSubmit()
        {
            var name = UserRegistrationRequest.Name;
        }
        private async Task InvalidRegistrationFormSubmit()
        {
            var name = UserRegistrationRequest.Name;
        }


        // ------------------------------------------------------------------

        // Events that run every time when component re-render.
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
        protected override async Task OnParametersSetAsync() { }
        // LifeCycle
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }



        // Events that only run whtn the componetnts are created the first time.

        public override Task SetParametersAsync(ParameterView parameters)
        {
            return base.SetParametersAsync(parameters);
        }
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();
        }

    }
}
