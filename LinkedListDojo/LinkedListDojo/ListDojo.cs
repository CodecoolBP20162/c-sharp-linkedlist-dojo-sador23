using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    interface ListDojo<T>
    {

        void Add(T item);
        void Reverse();
        bool IsEmpty();
        void Remove(T item);
    }
}
