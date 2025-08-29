using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string Name { get; private set; }
        public List<Student> StudentList { get; private set; }
        public DateTime SemesterStart { get; private set; }

        public ClassRoom(string name, List<Student> studentList, DateTime semesterStart)
        {
            Name = name;
            StudentList = studentList;
            SemesterStart = semesterStart;
        }

        private string Season(int birthMonth)
        {
            return birthMonth switch
            {
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                12 or 1 or 2 => "Winter",
                _ => "Invalid month"
            };
        }

        public void PrintSeasonBirthdays()
        {
            string[] allSeasons = { "Spring", "Summer", "Autumn", "Winter" };

            var seasonCounts = StudentList.GroupBy(student => Season(student.BirthMonth)).ToDictionary(group => group.Key, group => group.Count());

            foreach (var season in allSeasons)
            {
                int count = seasonCounts.ContainsKey(season) ? seasonCounts[season] : 0;
                Console.WriteLine($"{season}: {count}");
            }
        }


        public override string ToString()
        {
            string studentsString = (StudentList != null && StudentList.Count > 0 ? string.Join("\n", StudentList.Select(s => "  - " + s)) : "There are no students in this class.");

            return $"Class Name: {Name}\n" +
                   $"Semester start: {SemesterStart}\n" +
                   $"Students:\n" + studentsString;
        }
    }
}
