using System;
using System.Globalization;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods Namu darbas");
            //1
            int maxSk = Max(7, 6, 4);                                   // galite keisti skaicius
            Console.WriteLine("Didziausias skaicius: " + maxSk);

            //2
            bool rangeCorrect = InRange(7, 7, 4);                       // galite keisti skaicius
            Console.WriteLine("Pirmas skaicius kartojasi: " + rangeCorrect);

            //3
            bool isPrimal = IsPrimal(4);                                // galite keisti skaiciu
            Console.WriteLine("Skaicius pirminis: " + isPrimal);

            //4
            int random20 = D20();
            Console.WriteLine("Random skaicius nuo1 iki 20: " + random20);
            int random10 = D10();
            Console.WriteLine("Random skaicius nuo1 iki 10: " + random10);
            int random6 = D6();
            Console.WriteLine("Random skaicius nuo1 iki 6: " + random6);

            //5
            int teisingasNr = Method2Num();
            Console.WriteLine("Jusu numeris reziuose: " + teisingasNr);


        }
        //1
        static int Max(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        //2
        static bool InRange(int num1, int num2, int num3)
        {
            if (num1 == num2 || num1 == num3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //3
        static bool IsPrimal(double num1)
        {
            if (num1 == 1 || num1 == 0)
            {
                return false;
            }
            if (num1 == 2)
            {
                return true;
            }

            for (double i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //4
        static int D20()
        {
            Random random = new Random();

            int randomSK = random.Next(1, 21);
            return randomSK;
        }

        static int D10()
        {
            Random random = new Random();

            int randomSK = random.Next(1, 11);
            return randomSK;
        }

        static int D6()
        {
            Random random = new Random();

            int randomSK = random.Next(1, 7);
            return randomSK;
        }

        //5

        static int Method2Num()
        {
            int ivestasNumeris = EnteredNumber();
            bool arReziuose = IsInNumbers(ivestasNumeris);
            while (arReziuose != true)
            {
                Console.WriteLine("Jusu ivestas skaicius ne reziuose");
                ivestasNumeris = EnteredNumber();
                arReziuose = IsInNumbers(ivestasNumeris);
            }
            return ivestasNumeris;
        }

        static int EnteredNumber()
        {
            Console.Write("Iveskite skaiciu nuo 1 iki 10: ");
            int enteredNR = Convert.ToInt32(Console.ReadLine());
            return enteredNR;
        }
        static bool IsInNumbers(int enteredNumber, int fromNr = 1, int toNr = 10)
        {
            if (enteredNumber >= fromNr && enteredNumber <= toNr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
