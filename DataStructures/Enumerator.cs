using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class CustomEnumerator<T> : IEnumerator<T>
    {

        private Node<T> node;
        public virtual T Current
        {
            get
            {
                return node.Data;
            }
        }

        object IEnumerator.Current => Current;

        private Node<T> head;

        public CustomEnumerator(Node<T> h)
        {
            head = h;
            node = head;
        }

        public bool MoveNext()
        {
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

