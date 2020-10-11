using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1  Ivedam duomenis i Masyva
            int[] numbers = new int[10];
            Console.WriteLine("Iveskite 10 skaiciu i Masyva");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            // Atspausdinam ivestas reiksmes
            Console.Write("Masyvo ivesti skaiciai: ");
            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine();

            // Task 2
            int suma = SkaiciuSuma(numbers);
            Console.WriteLine("Masyvo skaiciu suma: " + suma);
            Console.WriteLine("Masyvo maziausias ivestas skaicius: " + MaziausiasSkaicius(numbers));
            Console.WriteLine("Masyvo didziausias ivestas skaicius: " + DidziausiasSkaicius(numbers));
            Console.Write("Masyvas be pasikartojanciu skaiciu: ");
            DuplikataiMasyve(numbers);
            Console.WriteLine();
            MasyvoLyginiaiNelyginiai(numbers);


            static int SkaiciuSuma(int[] data)
            {
                int sum = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    sum += data[i];
                }
                return sum;
            } 

            static int DidziausiasSkaicius(int[] data)
            {
                int value = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] > value)
                    {
                        value = data[i];
                    }
                }
                return value;
            } 

            static int MaziausiasSkaicius(int[] data)
            {
                int value = data[0];
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] < value)
                    {
                        value = data[i];
                    }
                }
                return value;
            } 

            static void DuplikataiMasyve(int[] data)
            {
                int[] beDuplikatu = new int[data.Length];
                bool nulioIsimtis = true;
                int ilgioIndex = 0;

                for (int i = 0; i < data.Length; i++) {
                    bool neDuplikatas = true;
                    // Leidziam pirmam ivestam nuliui buti masyve
                    if (data[i] == 0 && nulioIsimtis)
                    {
                        beDuplikatu[ilgioIndex] = data[i];
                        ilgioIndex++;
                        nulioIsimtis = false;
                    }
                    else
                    {
                        for (int j = 0; j < beDuplikatu.Length; j++)
                        {
                            if (beDuplikatu[j] == data[i])
                            {
                                neDuplikatas = false;
                            }
                        }
                        if (neDuplikatas)
                        {
                            beDuplikatu[ilgioIndex] = data[i];
                            ilgioIndex++;
                        }
                    }
                }

                for (int i = 0; i < ilgioIndex; i++)
                {
                    Console.Write(beDuplikatu[i] + ", ");

                }
            }

            static void MasyvoLyginiaiNelyginiai(int[] data, int num = 10)
            {
                int[] numOdd = new int[num];
                int[] numEven = new int[num];
                int evenIndex = 0;
                int oddIndex = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    int temp = data[i];

                    if (data[i] % 2 == 0)
                    {
                        numEven[evenIndex] = temp;
                        evenIndex++;
                    }
                    else
                    {
                        numOdd[oddIndex] = temp;
                        oddIndex++;
                    }
                }
                Console.WriteLine();
                Console.Write("Masyvo lyginiai skaiciai: ");
                foreach (var item in numEven)
                {
                    if (item != 0)
                    {
                        Console.Write(item + ", ");
                    }
                }
                Console.WriteLine();
                Console.Write("Masyvo nelyginiai skaiciai: ");
                foreach (var item in numOdd)
                {
                    if (item != 0)
                    {
                        Console.Write(item + ", ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Lists
            // Task 3
            List<int> enteredNumbers = new List<int>();
            List<int> enteredOdd = new List<int>();
            List<int> enteredEven = new List<int>();

            Console.WriteLine("Iveskite 10 skaiciu i Lista");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                enteredNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("\nListo ivesti skaiciai: ");
            foreach (int item in enteredNumbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            // Task 4

            // Shortcut
            //Console.WriteLine("Listo skaiciu suma: " + enteredNumbers.Sum());
            //Console.WriteLine("Listo maziausias skaicius: " + enteredNumbers.Min());
            //Console.WriteLine("Listo didziausias skaicius: " + enteredNumbers.Max());

            // Long Way
            Console.WriteLine("Listo skaiciu suma: " + ListoSuma(enteredNumbers));
            Console.WriteLine("Listo maziausias ivestas skaicius: " + ListoMaziausias(enteredNumbers));
            Console.WriteLine("Listo didziausias ivestas skaicius: " + ListoDidziausias(enteredNumbers));

            Console.Write("Listas be pasikartojanciu skaiciu: ");
            foreach (int item in ListasBeDuplikatu(enteredNumbers))
            {
                Console.Write(item + ", ");
            }

            static int ListoSuma(List<int> data)
            {
                int sum = 0;
                for (int i = 0; i < data.Count; i++)
                {
                    sum += data[i];
                }
                return sum;
            }
            static int ListoMaziausias(List<int> data)
            {
                int value = data[0];
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] < value)
                    {
                        value = data[i];
                    }
                }
                return value;
            }
            static int ListoDidziausias(List<int> data)
            {
                int value = data[0];
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] > value)
                    {
                        value = data[i];
                    }
                }
                return value;
            }

            static List<int> ListasBeDuplikatu(List<int> data)
            {
                return data.Distinct().ToList();
            }

            Console.WriteLine();
            for (int i = 0; i < enteredNumbers.Count; i++)
            {
                if (enteredNumbers[i] % 2 == 0)
                {
                    enteredEven.Add(enteredNumbers[i]);
                }
                else
                {
                    enteredOdd.Add(enteredNumbers[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Listo lyginiai skaiciai: ");
            foreach (int item in enteredEven)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.Write("Listo nelyginiai skaiciai: ");
            foreach (int item in enteredOdd)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
