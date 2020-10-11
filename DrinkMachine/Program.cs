using System;
using System.Diagnostics;

namespace GerimuAparatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norimo gerimo skaiciu: " +
                "\n1 - Limonadas \n2 - Arbata \n3 - Kakava \n4 - Kava \n5 - Nieko");
            Console.WriteLine();
            int pasirinkimoNumeris = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimoNumeris)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote limonada.");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote arbata.");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote kakava.");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava.");
                    break;
                case 5:
                    Console.WriteLine("Jus pasirinkote - nieko.");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas.");
                    break;
            }
        }
    }
}
