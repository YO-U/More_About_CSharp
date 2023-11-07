using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();// FILO dorst in last out первый вошел последний вышел 

            stack.Push(1);//добавляет 
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            while (stack.Count > 0)
            {
               Console.WriteLine(stack.Pop());//выводит элементы 
            }

            foreach (int i in stack) // хз не работает гавно
            {
                Console.WriteLine(i);
            }
        }
    }
}