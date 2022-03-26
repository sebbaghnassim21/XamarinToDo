using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToDoMobile.Helpers;
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
        //public bool response;

        public ICommand LoginCommand => new Command(async () =>
        {
            var accesstoken = await _apiServices.LoginAsync(Username, Password);
            Settings.AccessToken = accesstoken;
            if (!string.IsNullOrEmpty(accesstoken))
            {
               
                await App.Current.MainPage.Navigation.PushAsync(new ToDoPage());
            }
            else
            { await App.Current.MainPage.DisplayAlert("Erreur", "Erreur d'utilisateur ou de mot de passe", "OK"); }
            

        });
        public ICommand Register => new Command ( ()=>
        {
         App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
          //  Application.Current.MainPage = new NavigationPage(new RegisterPage());

        });

        public object GetTaskToDo { get; private set; }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
    }
}
