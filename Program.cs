using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(10);

            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(2);

            numbers.AddRange(new int[] { 1, 2, 3, 4 });

            numbers.RemoveAt(5);//удаление по индексу
            numbers.Remove(4);//удалить первую встречну 4
            numbers.IndexOf(5);//получить индекс позиции числа 5
            numbers.Insert(0, 2); //добавить элемент на 0 индекс

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}