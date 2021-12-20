using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Licz obj1 = new Licz();
            // Licz obj2 = new Licz();
            // Licz obj3 = new Licz();
            // obj1.numberValue = -3;
            // obj2.numberValue = 1.5f;
            // obj3.numberValue = 45.816f;
            // Console.WriteLine(obj3.Add(12));
            // obj3.ShowNumber();

            // Date date1 = new Date(1,3,2000);
            // date1.removeWeek();
            // Console.WriteLine(date1.readDate());
            // date1.addWeek();
            // Console.WriteLine(date1.readDate());

            Liczba liczba = new Liczba("193");
            Console.WriteLine(liczba.showNumber());
            Console.WriteLine(Liczba.factorialNumber(3));
        }
    }
}