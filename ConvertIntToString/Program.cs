using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters;

namespace SuperTaskIntChangeToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu: ");
            string enteredNumber = Console.ReadLine();

            Console.WriteLine("Ivesta reiksme: " + enteredNumber);

            if (IsItNumber(enteredNumber))
            {
                int intNumber = Convert.ToInt32(enteredNumber);
                ArReziuose(intNumber);
                if (intNumber == 0)
                {
                    Console.WriteLine("Ivestas skaicius zodziais: nulis"); ;
                }
                else
                {
                    Console.WriteLine("Ivestas skaicius zodziais: " + MinusIsTrue(intNumber));
                }
            }

            Console.WriteLine();
            // test loop just for me
            Console.Write("Iveskite skaiciu nuo kurio spausdinti: ");
            string minText = Console.ReadLine();
            Console.Write("Iveskite skaiciu iki kurio spausdinti: ");
            string maxText = Console.ReadLine();
            int minInt = Convert.ToInt32(minText);
            int maxInt = Convert.ToInt32(maxText);
            TestLoop(minInt, maxInt);
        }

        static bool IsItNumber(string data)
        {
            try
            {
                int skaicius = Convert.ToInt32(data);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Jusu ivedimas yra ne skaicius: " + data);
                return false;
            }

        }

        static void ArReziuose(int data)  // Tikrinam ar reziuose
        {

            if (data >= -9 && data <= 9)
            {
                Console.WriteLine("Skaicius reziuose nuo -9 iki 9");
            }
            else
            {
                Console.WriteLine("Skaicius ne reziuose nuo -9 iki 9");
            }
            Console.WriteLine();
        }

        static bool IsMinus(int data)  // tikrinam ar minusas
        {
            if (data < 0)
            {
                return true;
            }
            else
                return false;
        }

        static string MinusIsTrue(int data) // isvedimas i ekrana po minuso tikrinimo
        {
            if (IsMinus(data))
            {
                data = data * (-1);
                return "minus " + ChangeNumberToText(data);
            }
            return ChangeNumberToText(data);
        }

        static string ChangeNumberToText(int data) // isvedimas i ekrana
        {
            return From1000000To999999999(data);
        }

        static string From0To19(int data)
        {
            switch (data)
            {
                case 0:
                    return "";
                case 1:
                    return "vienas ";
                case 2:
                    return "du ";
                case 3:
                    return "trys ";
                case 4:
                    return "keturi ";
                case 5:
                    return "penki ";
                case 6:
                    return "sesi ";
                case 7:
                    return "septyni ";
                case 8:
                    return "astuoni ";
                case 9:
                    return "devyni ";
                case 10:
                    return "desimt ";
                case 11:
                    return "vienuolika ";
                case 12:
                    return "dvylika ";
                case 13:
                    return "trylika ";
                case 14:
                    return "keturiolika ";
                case 15:
                    return "penkiolika ";
                case 16:
                    return "sesiolika ";
                case 17:
                    return "septyniolika ";
                case 18:
                    return "astuoniolika ";
                case 19:
                    return "devyniolika ";
                default:
                    break;
            }
            return "Klaida - Nera tokio pasirinkimo 0 - 19"; // klaida skirta man jei kas nepavyktu
        }

        static string From20To99(int data)
        {
            if (data >= 20 && data <= 99)
            {
                int data1 = data / 10;

                switch (data1)
                {
                    case 2:
                        return "dvidesimt " + From0To19(data - 20);
                    case 3:
                        return "trisdesimt " + From0To19(data - 30);
                    case 4:
                        return "keturiasdesimt " + From0To19(data - 40);
                    case 5:
                        return "penkiasdesimt " + From0To19(data - 50);
                    case 6:
                        return "sesiasdesimt " + From0To19(data - 60);
                    case 7:
                        return "septyniasdesimt " + From0To19(data - 70);
                    case 8:
                        return "astuoniasdesimt " + From0To19(data - 80);
                    case 9:
                        return "devyniasdesimt " + From0To19(data - 90);
                    default:
                        break;
                }
            }
            else
            {
                return From0To19(data);
            }
            return "Klaida - Nera tokio pasirinkimo 20 - 99"; // klaida skirta man jei kas nepavyktu
        }

        static string From100To999(int data)
        {
            if (data >= 100 && data <= 999)
            {
                int data1 = data / 100;

                switch (data1)
                {

                    case 1:
                        return "simtas " + From20To99(data - 100);
                    case 2:
                        return "du simtai " + From20To99(data - 200);
                    case 3:
                        return "trys simtai " + From20To99(data - 300);
                    case 4:
                        return "keturi simtai " + From20To99(data - 400);
                    case 5:
                        return "penki simtai " + From20To99(data - 500);
                    case 6:
                        return "sesi simtai " + From20To99(data - 600);
                    case 7:
                        return "septyni simtai " + From20To99(data - 700);
                    case 8:
                        return "astuoni simtai " + From20To99(data - 800);
                    case 9:
                        return "devyni simtai " + From20To99(data - 900);
                    default:
                        break;
                }
            }
            else
            {
                return From20To99(data);
            }
            return "Klaida - Nera tokio pasirinkimo 100 - 999"; // klaida skirta man jei kas nepavyktu
        }

        static string From1000To999999(int data)
        {
            if ((data >= 1000 && data < 2000) || CheckOneThousandException(data))
            {
                return From100To999(data / 1000) + "tukstanis " + From100To999(data % 1000);
            }
            else if ((data % 100000 >= 10000 && data % 100000 < 20000) || CheckZeroThousandException(data))
            {
                return From100To999(data / 1000) + "tukstanciu " + From100To999(data % 1000);
            }
            else if ((data >= 2000 && data < 10000) || (data >= 20000 && data < 1000000))
            {
                return From100To999(data / 1000) + "tukstanciai " + From100To999(data % 1000);
            }
            else
            {
                return From100To999(data);
            }
        }

        static string From1000000To999999999(int data)
        {
            if ((data >= 1000000 && data < 2000000) || CheckOneMilionException(data))
            {
                return From1000To999999(data / 1000000) + "milijonas " + From1000To999999(data % 1000000);
            }
            else if ((data % 100000000 >= 10000000 && data % 100000000 < 20000000) || CheckZeroMilionException(data))
            {
                return From1000To999999(data / 1000000) + "milijonu " + From1000To999999(data % 1000000);
            }
            else if ((data >= 2000000 && data < 10000000) || (data >= 20000000 && data < 1000000000))
            {
                return From1000To999999(data / 1000000) + "milijonai " + From1000To999999(data % 1000000);
            }
            else
            {
                return From1000To999999(data);
            }
        }

        static bool CheckOneThousandException(int data)
        {
            int data1 = data / 1000;
            data1 = data1 % 10;
            if (data1 == 1 && ((data % 100000 < 11000 && data % 100000 >= 12000) || data % 100000 <= 2000))
            {
                return true;
            }
            return false;
        }

        static bool CheckZeroThousandException(int data)
        {
            if (data > 1000)
            {
                int data1 = data / 1000;
                data1 = data1 % 10;
                if (data1 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckOneMilionException(int data)
        {
            int data1 = data / 1000000;
            data1 = data1 % 10;
            if (data1 == 1 && ((data % 100000000 < 11000000 && data % 100000000 >= 12000000) || data % 100000000 <= 2000000))
            {
                return true;
            }
            return false;
        }

        static bool CheckZeroMilionException(int data)
        {
            if (data > 1000000)
            {
                int data1 = data / 1000000;
                data1 = data1 % 10;
                if (data1 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // test loop
        static void TestLoop(int min, int max)
        {
            for (int i = min; i < max; i++)
            {

                Console.WriteLine(ChangeNumberToText(i));
            }

        }

    }
}
