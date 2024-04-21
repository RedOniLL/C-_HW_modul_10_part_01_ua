using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_10_part_01_ua
{
    public class SingleLinkedList<T>
    {
        private Node<T> _head; 

        public SingleLinkedList()
        {
            _head = null;
        }

        public int Count { get; private set; } 

        public bool IsEmpty => _head == null; 

        public void AddFirst(T item)
        {
            var newNode = new Node<T>(item);
            newNode.Next = _head;
            _head = newNode;
            Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node<T>(item);

            if (IsEmpty)
            {
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            var item = _head.Value;
            _head = _head.Next;
            Count--;
            return item;
        }

        public T RemoveLast()
        {
            if (Count == 1)
            {
                return RemoveFirst();
            }

            var previous = _head;
            var current = _head.Next;

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            var item = current.Value;
            previous.Next = null;
            Count--;
            return item;
        }

        public T Find(T item)
        {
            var current = _head;

            while (current != null && !current.Value.Equals(item))
            {
                current = current.Next;
            }

            return current != null ? current.Value : default(T);
        }

        public void Clear()
        {
            _head = null;
            Count = 0;
        }

      

        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
    }

}
