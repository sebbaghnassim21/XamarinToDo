using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoMobile.Model
{
    class TaskToDo
    {
        public int id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string subject { get; set; }
        public int labelId { get; set; }
        public string location { get; set; }
    }
}
