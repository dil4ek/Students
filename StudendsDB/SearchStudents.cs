using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Newtonsoft.Json.JsonConvert;

namespace StudendsDB
{
    public static class SearchStudents
    {
        public static List<Students> FindAllStudents()
        {
            List<Students> students = new List<Students>();
            using (var context = new StudentsDB())
            {
                students = context.Students.ToList();
                for (int i = 0; i < students.Count; i++)
                {
                    string idStudnet = students[i].Id;
                    Semester semester = context.Semester.Where(x => x.StudentId == idStudnet).FirstOrDefault();
                    
                    int idSemester = semester.Id;
                    List<Scores> score = context.Scores.Where(x => x.SemesterID == idSemester).ToList();
                }
            };

            return students;
        
        }

        public static string GetJason()
        {
            var context = new StudentsDB();
            context.Configuration.ProxyCreationEnabled = false;

            List<Students> students = FindAllStudents();
            return JsonConvert.SerializeObject(students, Formatting.Indented,
               new JsonSerializerSettings
               {
                   ReferenceLoopHandling = ReferenceLoopHandling.Ignore
               });   
        }
    }
}
