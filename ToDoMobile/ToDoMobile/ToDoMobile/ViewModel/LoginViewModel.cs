using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToDoMobile.Services;
using Xamarin.Forms;

namespace ToDoMobile.ViewModel
{
    class LoginViewModel
    {
        private ApiServices _apiServices = new ApiServices();
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async() => {
                   await _apiServices.LoginAsync(Username, Password);
                     
                });
            }
        }

    }
}
