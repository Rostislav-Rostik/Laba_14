internal class Task9
{
    static void Main()
    {
        var list = new Dictionary<string, List<int>>();

        while (true)
        {
            var temp_list = Console.ReadLine().Split();
            if (temp_list[0] == "End" || temp_list[0] == "END")
            {
                break;
            }
            string first_number = "";
            first_number += temp_list[0];
            
            List<int> second_int = new();
            for (int i = 1; i != temp_list.Length; i++)
            {
                try
                {
                    second_int.Add(int.Parse(temp_list[i]));
                }
                catch (Exception)
                {
                }
                
            }

            list.Add(first_number, second_int);
        }

        var selectedPeople = list.Where(x => x.Key.EndsWith("14") || x.Key.EndsWith("15"));

        foreach (var item in selectedPeople)
        {
            foreach (var item2 in item.Value)
            {
                Console.Write(item2 + " ");
            }
            Console.WriteLine();
        }
    }
}