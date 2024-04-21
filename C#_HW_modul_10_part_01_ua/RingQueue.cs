using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_10_part_01_ua
{
    public class RingQueue<T>
    {
        private  T[] _buffer;
        private int _head;
        private int _tail;
        private int _size;

        public RingQueue(int capacity)
        {
            _buffer = new T[capacity];
            _head = _tail = 0;
            _size = 0;
        }

        public int Capacity => _buffer.Length;

        public int Count => _size;

        public bool IsEmpty => _size == 0;

        public bool IsFull => _size == Capacity;

        public void Enqueue(T item)
        {
  
            _buffer[_tail] = item;
            _tail = (_tail + 1) % Capacity;
            _size++;
        }

        public T Dequeue()
        {
  
            var item = _buffer[_head];
            _head = (_head + 1) % Capacity;
            _size--;
            return item;
        }

        public T Peek()
        {
            return _buffer[_head];
        }

        public void Clear()
        {
            _head = _tail = 0;
            _size = 0;
        }

       
    }

}
