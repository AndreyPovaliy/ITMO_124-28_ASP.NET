using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_task.Models
{
    public class StudentsRepository

    {
        private List<Students> students = new List<Students>();
        public int NumberOfStudents
        {
            get
            {
                return students.Count();
            }
        }
        public IEnumerable<Students> GetAllResponses
        {
            get
            {
                return students;
            }
        }
        public void AddResponse(Students pers) 
        { 
            students.Add(pers); 
        }
    }
}