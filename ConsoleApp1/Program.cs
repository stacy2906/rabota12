using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.

            //1.Создать пустой список целого типа.


            //2.Добавить следующие элементы в коллекцию: 1, 10, 25, 17, 10.

            //    List<int> ints = new List<int>();
            //    ints.Add(1);
            //    ints.Add(10);
            //    ints.Add(25);
            //    ints.Add(17);
            //    ints.Add(10);
            //    Func(ints);
            //    Console.ReadKey();
            //}
            //static void Func(List<int> ints)
            //{
            //  foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

            //3.Через дополнительный метод просмотреть содержимое списка.

          
            //static void Func(List<int> ints)
            //{
            //  foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine($"Count: = {ints.Count}");
            //}

            //4.Определить количество элементов списка.

            //static void Func(List<int> ints)
            //{
            //  foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine($"Capacity: = {ints.Capacity}");
            //}

            //5.Определить индекс элемента со значением, равным 25.

      
            //static void Func(List<int> ints)
            //{
            //  foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine($"Index 25: = {ints.IndexOf(25)}");
            //}


            //6.Удалить из списка первый элемент со значением 10 и через дополнительный метод просмотреть содержимое списка.


            //    List<int> ints = new List<int>();
            //    ints.Add(1);
            //    ints.Add(10);
            //    ints.Add(25);
            //    ints.Add(17);
            //    ints.Add(10);
            //    ints.RemoveAt(1);
            //    foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //        Func(ints);
            //    Console.ReadKey();
            //}
            //static void Func(List<int> ints)
            //{
            //    Console.WriteLine($"Capacity: = {ints.Capacity}");
            //}



            //7.Удалить из списка элемент с индексом, равным 2 и через дополнительный метод просмотреть содержимое списка.
            //    List<int> ints = new List<int>();
            //    ints.Add(1);
            //    ints.Add(10);
            //    ints.Add(25);
            //    ints.Add(17);
            //    ints.Add(10);
            //    ints.RemoveAt(2);
            //    foreach (var item in ints)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Func(ints);
            //    Console.ReadKey();
            //}
            //static void Func(List<int> ints)
            //{
            //  Console.WriteLine($"Capacity: = {ints.Capacity}");
            //}


            //8.Проверить наличие элемента со значением 25 в списке.
        //    List<int> ints = new List<int>();
        //    ints.Add(1);
        //    ints.Add(10);
        //    ints.Add(25);
        //    ints.Add(17);
        //    ints.Add(10);
        //    Func2(ints);
        //    ints.RemoveAt(2);
        //    Func2(ints);
        //    Console.WriteLine($"Count: = {ints.Count}");
        //    Contains(ints);
        //    Console.ReadKey();
        //}
        //static void Func2(List<int> ints)
        //{
        //    foreach (var item in ints)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine();
           

        //}
        //static bool Contains(List<int> item)
        //{
        //    if (item == null) return false;
            return (item.Equals(int.));
        }

        //9.Вставить число 500 в самом начале списка и через дополнительный метод просмотреть содержимое списка.
        //    List<int> ints = new List<int>();
        //    ints.Add(500);
        //    ints.Add(1);
        //    ints.Add(10);
        //    ints.Add(25);
        //    ints.Add(17);
        //    ints.Add(10);
        //    foreach (var item in ints)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Func(ints);
        //    Console.ReadKey();
        //}
        //static void Func(List<int> ints)
        //{
        //    Console.WriteLine($"Count: = {ints.Count}");
        //}

        //10.Отсортировать элементы списка по возрастанию и через дополнительный метод просмотреть содержимое списка.
            List<int> ints = new List<int>();
            ints.Add(500);
            ints.Add(1);
            ints.Add(10);
            ints.Add(25);
            ints.Add(17);
            ints.Add(10);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Func(ints);
    Console.ReadKey();
        }
static void Func(List<int> ints)
{
    Console.WriteLine($"Count: = {ints.Count}");
}

        //11.Изменить значение нулевого элемента списка на величину, равную сумме первого элемента и числа.

        //12.Через дополнительный метод просмотреть содержимое списка.

        //Задание  2.Удалить все нечетные элементы списка, заполненного случайным образом целыми числами.


        //Задание 3.Записана информация о стоимости каждого из 20 видов товара, продаваемых фирмой.С 1 января очередного года фирма прекращает продавать товар, стоимость которого записана в n - м элементе списка. Получить список со стоимостью всех оставшихся видов товара.

        //Задание 4.Создать линейный однонаправленный список из целых чисел. Определить сумму значений элементов списка, кратных 5.

        //Задание 5.Создать линейный однонаправленный список из целых чисел. Вставить в список число 10 после каждого элемента с отрицательным значением.

    }
}

