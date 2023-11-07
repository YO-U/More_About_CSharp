using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();// FIFO first in first out первый зашел первый вышел

            queue.Enqueue("Vasa");//добавить элемент
            queue.Enqueue("Roma");
            queue.Enqueue("Goga");
            queue.Enqueue("Popka");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Dequeue());//использует первый по списку элемент и убирает его
            Console.WriteLine(queue.Peek());//показывает какой элемент будет после первого

        }
    }
}