using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    public class SingleLinkedList <T> : ListDojo<T>
    {
        public Node<T> head = null;
        public Node<T> last = null;
        public int lenght { get; set; }

        public SingleLinkedList()
        {
            lenght = 0;
        }

        public SingleLinkedList(T item)
        {
            lenght = 0;
            head = new Node<T>(item);
            last = head;
            lenght++;
        }

        public void Add(T item)
        {
            if(head != null)
            {

            Node<T> node = new Node<T>(item);
            last.next = node;
            last = node;

            }
            else
            {
                head = new Node<T>(item);
                last = head;
            }
            lenght++;
        }

        public bool IsEmpty()
        {
            if (head != null) return false;
            else return true;
        }

        public void Remove(T item)
        {
            if (head.value.Equals(item))
            {
                try
                {
                    head = head.next;
                    return;
                }
                catch (Exception e)
                {
                    head = null;
                    last = null;
                    return;

                }
                Node<T> node = head;
                T value;
                for (int i = 0; i < lenght; i++)
                {
                    if (node.HasNext())
                    {
                        try
                        {
                            value = node.next.value;
                        }
                        catch (Exception ex)
                        {
                            break;
                        }

                        if (value.Equals(item))
                        {
                            try
                            {
                                node.next = node.next.next;
                            }
                            catch (Exception e)
                            {
                                last = node;
                            }
                        }
                    }
                    try
                    {
                        node = node.next;
                    }
                    catch (Exception e)
                    {
                        break;
                    }
                }
            }

        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
