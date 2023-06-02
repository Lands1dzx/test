using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2018, 7, 20);
            DateTime date2 = new DateTime(2018, 8, 19);
            DateTime date3 = new DateTime(2017, 11, 4);
            DateTime date4 = new DateTime(2014, 7, 5);
            DateTime date5 = new DateTime(2019, 3, 4);
            DateTime date6 = new DateTime(2008, 6, 6);
            var a = new Processors("intel core i5", 15, date1);
            var b = new Processors("intel core i3", 20,date2);
            var c = new Processors("intel core i9", 10, date3);
            var d = new Processors("intel core i7", 12, date6);
            var e = new Processors("amd ryzen 3", 21, date6);
            var f = new Processors("amd ryzen 5", 24, date5);
            var g = new Processors("amd ryzen 7", 14, date3);
            var h = new Processors("amd ryzen 9", 2, date1);
            var k = new Processors("amd ryzen threadripper", 1, date2);
            var l = new Processors("intel celeron", 40, date4);

            Processors[] objs = new Processors[10] { a, b, c, d, e, f, g, h, k, l };
            var maxQuantity = Methods.MaxQuantity(objs);
            var nameSearch = Methods.NameSearch(objs, "intel");
            var dateSort = Methods.DateSort(objs);
            Console.WriteLine("Максимальное количество:");
            foreach (Processors s in maxQuantity)
            {
                Console.WriteLine(s.name + " " + s.quantity + " " + $"{s.dateTime.ToString("d")}");
            }
            Console.WriteLine("Поиск по имени:");
            foreach (Processors s in nameSearch)
            {
                Console.WriteLine(s.name + " " + s.quantity + " " + $"{s.dateTime.ToString("d")}");
            }
            Console.WriteLine("Сортировка по дате:");
            foreach (Processors s in dateSort)
            {
                Console.WriteLine(s.name + " " + s.quantity + " " + $"{s.dateTime.ToString("d")}");
            }
        }
    }
}
