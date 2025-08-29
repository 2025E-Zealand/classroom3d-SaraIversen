// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;
using System.Xml.Linq;

ClassRoom classRoom = new ClassRoom(
    name: "3Q Beginning of the semester",
    studentList: new List<Student>
    {
        new Student(name: "Person1", birthMonth: 4, birthDay: 17),
        new Student(name: "Person2", birthMonth: 2, birthDay: 14),
        new Student(name: "Person3", birthMonth: 12, birthDay: 24)
    },
    semesterStart: new DateTime(2019, 8, 26)
);

Console.WriteLine(classRoom.ToString());

Console.WriteLine();

classRoom.PrintSeasonBirthdays();