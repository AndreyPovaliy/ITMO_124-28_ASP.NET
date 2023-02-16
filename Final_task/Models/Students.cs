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
        public int Subject_1 { get; set; }
        public int Subject_2 { get; set; }
        public int Subject_3 { get; set; }
        public int Subject_4 { get; set; }
        public int Subject_5 { get; set; }

        

        public override string ToString() 
        {
            int sum = Subject_1 + Subject_2 + Subject_3 + Subject_4 + Subject_5;
            string s = FirstName + " " + LastName + " группа №" + Group  + "сумма баллов=" + sum; 
            return s; 
        }
    }
}