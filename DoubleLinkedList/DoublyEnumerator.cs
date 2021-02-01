using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class DoublyEnumerator<T> : IEnumerator<T>
    {
        private DoublyNode<T> node;
        public virtual T Current
        {
            get
            {
                return node.Data;
            }
        }

        object IEnumerator.Current => Current;

        private DoublyNode<T> head;

        public DoublyEnumerator(DoublyNode<T> h)
        {
            head = h;
        }
        public bool MoveNext()
        {
            if (head == null) return false;
            if (node == null)
            {
                node = head;
                return true;
            }
            if (node.Next != null)
            {
                node = node.Next;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            node = head;
        }

        public void Dispose() { }
    }
}

