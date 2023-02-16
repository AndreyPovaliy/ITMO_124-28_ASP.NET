using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_task.Models
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Subject_1 { get; set; }
        public string Subject_2 { get; set; }
        public string Subject_3 { get; set; }
        public string Subject_4 { get; set; }
        public string Subject_5 { get; set; }

        public override string ToString() 
        { 
            string s = FirstName + " " + LastName; 
            return s; 
        }
    }
}