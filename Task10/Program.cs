using System.Collections.Generic;

internal class Program
{
    class Person 
    {
        public string name { get; set; }
        public string age { get; set; }
    }

    static void Main()
    {
        List<Person> person = new List<Person>();

        while (true)
        {
            var temp = Console.ReadLine().Split();
            if (temp[0] == "End" || temp[0] == "END")
            {
                break;
            }

            string name = temp[0] + " " + temp[1];

            string age = temp[2];

            Person person1 = new Person();
            person1.name = name;
            person1.age = age;

            person.Add(person1);
        }
        var selectedPeople = person.GroupBy(x => x.age);
        foreach (var item in selectedPeople)
        {
            string tempGroup = "";
            foreach (var item2 in item)
            {
                tempGroup = item2.age;
                Console.Write(item2.name + " ");
            }
            Console.Write("- " + tempGroup);
            Console.WriteLine();
        }
    }
}