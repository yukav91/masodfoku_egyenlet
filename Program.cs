using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Másodfokú egyenlet!\nKérlek, add meg az 'a' értékét:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérlek, add meg a 'b' értékét:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérlek, add meg a 'c' értékét:");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Az egyenlet nem másodfokú");
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Nincs valós megoldás");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("\nAz x1 értéke: " + x1 + "\nAz x2 értéke: " + x2);
                }
            }
        }
    }
}
