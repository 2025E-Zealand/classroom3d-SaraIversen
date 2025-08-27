using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
