internal class Task7
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
            string first_string = "";
            first_string += temp_list[0] + " " + temp_list[1];

            List<int> second_int = new();
            for (int i = 2; i != temp_list.Length; i++)
            {
                second_int.Add(int.Parse(temp_list[i]));
            }

            list.Add(first_string, second_int);
        }

        
        var number = (List<int> temp) =>
        {
            int index = 0;
            foreach (int a in temp)
            {
                if (a <= 3)
                {
                    index++;
                }
            }
            if (index >= 2 )
            {
                return 1;
            }

            return 0;
        };


        var selectedPeople = list.Where(x => number(x.Value) == 1); 


        foreach (var item in selectedPeople)
        {
            Console.WriteLine(item.Key);
        }
    }
}