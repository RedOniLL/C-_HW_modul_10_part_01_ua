using System;


namespace C__HW_modul_10_part_01_ua
{
    public class MyQueue<T>
    {
        private List<T> elements = new List<T>();

        public int Count => elements.Count;

        public void Enqueue(T item)
        {
            elements.Add(item);
        }

        public T Dequeue()
        {
            T item = elements[0];
            elements.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            return elements[0];
        }

        public bool Contains(T item)
        {
            return elements.Contains(item);
        }

        public void Clear()
        {
            elements.Clear();
        }
    }
}
