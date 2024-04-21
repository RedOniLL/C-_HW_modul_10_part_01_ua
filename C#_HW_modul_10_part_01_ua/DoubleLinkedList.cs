using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_10_part_01_ua
{
    public class DoubleLinkedList<T>
    {
        private Node<T> _head; 
        private Node<T> _tail; 

        public DoubleLinkedList()
        {
            _head = null;
            _tail = null;
        }

        public int Count { get; private set; } 

        public bool IsEmpty => _head == null; 

        public void AddFirst(T item)
        {
            var newNode = new Node<T>(item);

            if (IsEmpty)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node<T>(item);

            if (IsEmpty)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }

            Count++;
        }

        public T RemoveFirst()
        {
           
            var item = _head.Value;

            if (Count == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head.Next.Previous = null;
                _head = _head.Next;
            }

            Count--;
            return item;
        }

        public T RemoveLast()
        {
           
            var item = _tail.Value;

            if (Count == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail.Previous.Next = null;
                _tail = _tail.Previous;
            }

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
            _tail = null;
            Count = 0;
        }

       

        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Previous { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Previous = null;
                Next = null;
            }
        }
    }
}
