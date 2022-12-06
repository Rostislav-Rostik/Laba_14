internal class Task1
{
    static void Main()
    { 
        var list = new Dictionary<string, int>();

        while (true)
        {
            var temp_list = Console.ReadLine().Split();
            if (temp_list[0] == "End" || temp_list[0] == "END")
            {
                break;
            }
            list.Add(temp_list[0] + " " + temp_list[1], int.Parse(temp_list[2]));
        }

        var selectedPeople = list.Where(x => x.Value == 2);

        foreach (var item in selectedPeople)
        {
            Console.WriteLine(item.Key);
        }
    }
}