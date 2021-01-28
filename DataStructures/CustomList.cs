using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CustomList<T> : IEnumerable 
    {
        public Node<T> head; 
        public Node<T> tail; 
        int count;  // количество элементов в списке

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
      
        public void AddAt(Node<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node<T> new_node = new Node<T>(data);
            new_node.Next = prev_node.Next;
            prev_node.Next = new_node;
        }
        public int Length { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void DeleteList()
        {
            head = null;
            tail = null;
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        // реализация интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return new CustomEnumerator<T>(head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
