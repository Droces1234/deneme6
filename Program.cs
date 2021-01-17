using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, sonuc;
            Console.Write("A değeri: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("B değeri: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("C değeri: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("D değeri: ");
            d = Convert.ToInt16(Console.ReadLine());
            sonuc = Math.Abs((a * d) - (b * c));
            Console.Write("determinant: " + sonuc);
            Console.ReadLine();
        } 
    }
}