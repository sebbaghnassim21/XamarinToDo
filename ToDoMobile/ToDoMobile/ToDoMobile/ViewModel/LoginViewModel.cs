using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToDoMobile.Services;
using ToDoMobile.Views;
using Xamarin.Forms;

namespace ToDoMobile.ViewModel
{
    class LoginViewModel
    {
        private ApiServices _apiServices = new ApiServices();
        public string Username { get; set; }
        public string Password { get; set; }
        public bool response;

        public ICommand LoginCommand => new Command(async () =>
        {
            response = await _apiServices.LoginAsync(Username, Password);

            if (response = true)
            {
               await App.Current.MainPage.Navigation.PushAsync(new ToDoPage());
              //  Application.Current.MainPage = new NavigationPage(new ToDoPage());
            }

        });
        public ICommand Register => new Command ( ()=>
        {
         App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
          //  Application.Current.MainPage = new NavigationPage(new RegisterPage());

        });
    }
}
