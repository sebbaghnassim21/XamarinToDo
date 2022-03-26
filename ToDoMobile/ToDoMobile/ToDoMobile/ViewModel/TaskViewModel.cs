using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ToDoMobile.Helpers;
using ToDoMobile.Model;
using ToDoMobile.Services;
using Xamarin.Forms;

namespace ToDoMobile.ViewModel
{
    class TaskViewModel : INotifyPropertyChanged
    {
        ApiServices _apiServices = new ApiServices();
        public List<TaskToDo> taskToDo;

   
        public List<TaskToDo> TaskToDo
        {
            get { return taskToDo; }
            set { taskToDo = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetTaskToDo
        {
            get
            {
                return new Command(async () =>
                {
                    var AccessToken = Settings.AccessToken;
                    TaskToDo = await _apiServices.GetTaskToDo(AccessToken);
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

