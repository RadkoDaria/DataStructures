using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> linkedList = new CustomList<string>();
            // добавление элементов
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.AddAt(linkedList.head.Next, "Tony");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
