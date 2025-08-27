// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom classRoom = new ClassRoom(
    name: "3Q Beginning of the semester",
    studentList: new List<Student>
    {
        new Student("Person1", 4, 17),
        new Student("Person2", 2, 14),
        new Student("Person3", 12, 24)
    },
    semesterStart: new DateTime(2019, 8, 26)
);