using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    interface IHybridFlowProcessor<T> 
    {
        void Push( T item);
        T Pop();
        void Enqueue( T item);
        T Dequeue();

    }
}
