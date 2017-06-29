using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    public class Node <T>
    {
        public Node<T> next = null;
        public T value;

        public Node(T item)
        {
            value = item;
        }

        public bool HasNext()
        {
            if (next == null) return false;
            else return true;
        }
    }
}
