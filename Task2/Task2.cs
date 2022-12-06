internal class Task2
{
    static void Main()
    {
        var list = new Dictionary<string, string>();

        
        while (true)
        {
            var temp_list = Console.ReadLine().Split();
            if (temp_list[0] == "End" || temp_list[0] == "END")
            {
                break;
            }
            list.Add(temp_list[0], temp_list[1]);
        }

        var selectedPeople = list.Where(x => x.Value.CompareTo(x.Key) == 1);

        foreach (var item in selectedPeople)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}