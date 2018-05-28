using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudendsDB
{
    public class StudentsDB : DbContext
    {
        static StudentsDB()
        {
            Database.SetInitializer(new NullDatabaseInitializer<StudentsDB>());
        }

        public StudentsDB()
            : base("Students")
        { 
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Scores> Scores { get; set; }
    }
}
