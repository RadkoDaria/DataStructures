using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList2<string> usersDeck = new CustomList2<string>();
            usersDeck.Push("Tom");
            usersDeck.Push("Alice");
            usersDeck.Enqueue("Bob");
            usersDeck.Enqueue("Sam");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.Pop();
            string removedItem2 = usersDeck.Dequeue();
            Console.WriteLine("\n Deleted: {0} \n", removedItem);
            Console.WriteLine("\n Deleted: {0} \n", removedItem2);

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
