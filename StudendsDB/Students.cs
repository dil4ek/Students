using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendsDB
{
    public class Students
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public List<Semester> Semester { get; set; }

        public Students()
        {
            Semester = new List<Semester>();
        }
    }

    public class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StudentId { get; set; }
        public List<Scores> Scores { get; set; }

        public Semester()
        {
            Scores = new List<Scores>();
        }
    }

    public class Scores
    {
        public int Id { get; set; }
        public string DisciplineName { get; set; }
        public string ProfessorName { get; set; }
        public int SemesterID { get; set; }
        public string Score { get; set; }
    }
}
