using System;

internal class Task11
{
    class StudentSpecialty
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }

    static void Main()
    {
        var listSpecialty = new List<StudentSpecialty>();
        var listStudent = new List<Student>();

        while (true)
        {
            var temp = Console.ReadLine().Split();
            if (temp[0] == "Students:")
            {
                break;
            }

            string name = temp[0] + " " + temp[1];

            string number = temp[2];

            StudentSpecialty specialty1 = new StudentSpecialty();
            specialty1.Name = name;
            specialty1.Number = number;

            listSpecialty.Add(specialty1);
        }

        while (true)
        {
            var temp = Console.ReadLine().Split();
            if (temp[0] == "End" || temp[0] == "END")
            {
                break;
            }

            string name = temp[0] + " " + temp[1];

            string number = temp[2];

            Student student1 = new Student();
            student1.Name = name;
            student1.Number = number;

            listStudent.Add(student1);
        }
        var selectedPeople = from person in listStudent
                             join faculty in listSpecialty on person.Number equals faculty.Number
                             orderby person.Name
                             select new
                             {
                                 student_name = person.Name,
                                 faculty_name = faculty.Name,
                                 faculty_number = faculty.Number
                             };
        foreach (var item in selectedPeople)
        {
            Console.WriteLine(item.student_name + " " + item.faculty_number + " " + item.faculty_name);
        }
    }
}