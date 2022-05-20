using System;

namespace homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            int pics = 52;
            int row = pics / 3;
            int remainder = pics % 3;
            Console.WriteLine("Количество заполненных рядов " + row);
            Console.WriteLine("Количество картин сверх меры " + remainder);
        }
    }
}
