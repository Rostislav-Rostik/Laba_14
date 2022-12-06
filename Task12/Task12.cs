using System;
using System.Collections.Generic;
using System.Linq;
internal class Task12
{
    class Company
    {
        public string Name { get; set; }
        public string Product { get; set; }

        public int Amount { get; set; }

        public Company(string name, string product, int am)
        {
            Name = name;
            Product = product;
            Amount = am;
        }
    }
    static void Main()
    {

        List<Company> list = new List<Company>();

        while (true)
        {
            string[] text = Console.ReadLine().Split('<', '>', '-', ' ', '|');
            List<string> temp = new List<string>();

            if (text[0] == "End")
            {
                break;
            }
            foreach (string s in text)
            {
                if (s != "" && s != " ")
                {
                    temp.Add(s);
                }
            }
            list.Add(new Company(temp[0], temp[2], int.Parse(temp[1])));
        }

        var groupedCustomerList = list.GroupBy(x => x.Name).Select(g => g.ToList());

        foreach (var item in groupedCustomerList)
        {
            Console.Write(item[0].Name + " ");
            foreach (var item1 in item)
            {
                Console.Write(item1.Product + " " + item1.Amount + "; ");
            }
            Console.WriteLine();
        }
    }
}