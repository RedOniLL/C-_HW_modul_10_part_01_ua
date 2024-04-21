using System;


namespace C__HW_modul_10_part_01_ua
{
    public class Swap<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Swap(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void ToSwap()
        {
            T temp = First;
            First = Second;
            Second = temp;
        }
    }
}
