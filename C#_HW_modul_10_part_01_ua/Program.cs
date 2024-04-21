using System.Reflection;

namespace C__HW_modul_10_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choise");
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
                    RingQueue<int> queue1 = new RingQueue<int>(5);

                    queue1.Enqueue(10);
                    queue1.Enqueue(20);
                    queue1.Enqueue(30);

                    Console.WriteLine($"Count: {queue1.Count}, Capacity: {queue1.Capacity}");

                    int dequeuedItem = queue1.Dequeue();
                    Console.WriteLine($"Dequeued Item: {dequeuedItem}");

                    Console.WriteLine($"Count: {queue1.Count}, Capacity: {queue1.Capacity}");

                    int peekedItem = queue1.Peek();
                    Console.WriteLine($"Peeked Item: {peekedItem}");

                    queue1.Clear();

                    Console.WriteLine($"Count: {queue1.Count}, Capacity: {queue1.Capacity}");
                    break ;
                case 3:
                    SingleLinkedList<int> list = new SingleLinkedList<int>();

                    list.AddFirst(10);
                    list.AddLast(20);
                    list.AddLast(30);

                    Console.WriteLine($"List Count: {list.Count}");
                    Console.WriteLine($"Is List Empty: {list.IsEmpty}");

                    int removedItem = list.RemoveFirst();
                    Console.WriteLine($"Removed Item: {removedItem}");

                    Console.WriteLine($"List Count after RemoveFirst: {list.Count}");

                    list.AddLast(40);
                    list.AddLast(50);

                    Console.WriteLine($"List Count after AddLast: {list.Count}");

                    int searchItem = 40;
                    int foundItem = list.Find(searchItem);
                    Console.WriteLine($"Found Item {searchItem}: {foundItem}");

                    int removedLastItem = list.RemoveLast();
                    Console.WriteLine($"Removed Last Item: {removedLastItem}");

                    Console.WriteLine($"List Count after RemoveLast: {list.Count}");

                    list.Clear();

                    Console.WriteLine($"List Count after Clear: {list.Count}");
                    Console.WriteLine($"Is List Empty after Clear: {list.IsEmpty}");
                    break;
                case 4:
                    DoubleLinkedList<int> list1 = new DoubleLinkedList<int>();

                    list1.AddFirst(10);
                    list1.AddLast(20);
                    list1.AddLast(30);

                    Console.WriteLine($"List Count: {list1.Count}");
                    Console.WriteLine($"Is List Empty: {list1.IsEmpty}");

                    int removedItem1 = list1.RemoveFirst();
                    Console.WriteLine($"Removed First Item: {removedItem1}");

                    int removedLastItem1 = list1.RemoveLast();
                    Console.WriteLine($"Removed Last Item: {removedLastItem1}");

                    Console.WriteLine($"List Count after Removal: {list1.Count}");

                    int searchItem1 = 20;
                    int foundItem1 = list1.Find(searchItem1);
                    Console.WriteLine($"Found Item {searchItem1}: {foundItem1}");

                    list1.Clear();

                    Console.WriteLine($"List Count after Clear: {list1.Count}");
                    Console.WriteLine($"Is List Empty after Clear: {list1.IsEmpty}");
                    break ;
            }
        }
    }
}
