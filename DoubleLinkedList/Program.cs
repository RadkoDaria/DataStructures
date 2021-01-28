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
            usersDeck.Push("Alice");
            usersDeck.Push("Kate");
            usersDeck.Push("Tom");

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            string removedItem = usersDeck.Pop();
            Console.WriteLine("\n Удален: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
