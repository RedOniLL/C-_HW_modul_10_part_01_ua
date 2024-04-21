using System.Reflection;

namespace C__HW_modul_10_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int c = int.Parse(Console.ReadLine());
            switch (c) { 
                case 0:

                    int a = 10;
                    int b = 20;
                    Console.WriteLine($"Before swap: a = {a}, b = {b}");

                    Swap<int> intSwap = new Swap<int>(a, b);
                    intSwap.ToSwap();

                    Console.WriteLine($"After swap: a = {intSwap.First}, b = {intSwap.Second}");

                    string str1 = "Hello";
                    string str2 = "World";
                    Console.WriteLine($"Before swap: str1 = {str1}, str2 = {str2}");

                    Swap<string> stringSwap = new Swap<string>(str1, str2);
                    stringSwap.ToSwap();

                    Console.WriteLine($"After swap: str1 = {stringSwap.First}, str2 = {stringSwap.Second}");
                    break;
                case 1:
                    MyQueue<string> queue = new MyQueue<string>();

                    queue.Enqueue("Task 1");
                    queue.Enqueue("Task 2");
                    queue.Enqueue("Task 3");

                    Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
                    Console.WriteLine($"Next item in queue: {queue.Peek()}");
                    break ;
                case 2:
                    RingQueue<int> queue = new RingQueue<int>(5);

                    queue.Enqueue(10);
                    queue.Enqueue(20);
                    queue.Enqueue(30);

                    Console.WriteLine($"Count: {queue.Count}, Capacity: {queue.Capacity}");

                    int dequeuedItem = queue.Dequeue();
                    Console.WriteLine($"Dequeued Item: {dequeuedItem}");

                    Console.WriteLine($"Count: {queue.Count}, Capacity: {queue.Capacity}");

                    int peekedItem = queue.Peek();
                    Console.WriteLine($"Peeked Item: {peekedItem}");

                    queue.Clear();

                    Console.WriteLine($"Count: {queue.Count}, Capacity: {queue.Capacity}");
                    break ;
            }
        }
    }
}
