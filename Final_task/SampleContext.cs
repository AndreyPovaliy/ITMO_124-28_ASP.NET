using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Final_task.Models;

namespace Final_task
{
    public class SampleContext : DbContext
    {
        
        public DbSet<Students> StudentsResponses 
        { 
            get; set; 
        }
    }
}