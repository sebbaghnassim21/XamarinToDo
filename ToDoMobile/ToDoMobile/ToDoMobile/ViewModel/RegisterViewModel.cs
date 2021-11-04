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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

        ApiServices _apiservices = new ApiServices();


        public ICommand RegisterCommand
        {

            get
            {
                return new Command(async() =>
                {

                   await _apiservices.RegisterAsync(firstName, lastName, email, password,confirmPassword);
                }
                );
            }
        }
    }
}
