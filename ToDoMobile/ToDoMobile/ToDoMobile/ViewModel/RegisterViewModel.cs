using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToDoMobile.Services;
using Xamarin.Forms;

namespace ToDoMobile.ViewModel
{
    class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        ApiServices _apiservices = new ApiServices();


        public ICommand RegisterCommand
        {

            get
            {
                return new Command(() =>
                {
                    _apiservices.RegisterAsync(Email ,Password,ConfirmPassword);
                }
                );
            }
        }
    }
}
