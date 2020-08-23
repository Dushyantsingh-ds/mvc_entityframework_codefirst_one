using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Approach_in_Entity_Framework.Models
{
    public class StudentContext : DbContext
    {
        // Database Instance Name

        public StudentContext(): base("DefaultConnection"){
        }
        public DbSet<Student> Students { get; set; }
    }
}


