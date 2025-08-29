using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public Student(string name, int birthMonth, int birthDay)
        {
            if (birthMonth < 1 || birthMonth > 12) throw new ArgumentOutOfRangeException("BirthMonth must be between 1 and 12.");

            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"{Name}, {BirthDay}/{BirthMonth}";
        }
    }
}
