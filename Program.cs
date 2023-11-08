using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1, "Петя1");//добавление
            dic.Add(2, "Петя2");
            dic.Add(3, "Петя3");

            if (dic.ContainsKey(1))//проверка на наличие ключа
            {
                Console.WriteLine(dic[1]);// Вывод данного с этим ключом 
            }

            foreach (var item in dic)//перебор по элементам 
            {
                Console.WriteLine( item.Key +" "+ item.Value);
            }
            foreach (var item in dic.Keys)//перебор по ключам
            {
                Console.WriteLine(item);
            }
            foreach (var item in dic.Values)// перебор по значениям ключей
            {
                Console.WriteLine(item);
            }
            dic.Remove(1);//удаление элемента по ключу
        }
    }
}