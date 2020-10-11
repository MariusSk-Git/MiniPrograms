using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            string character;
            float answer;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter character: X , /, +, -");
            character = (Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            

                switch (character)
                {
                    case "X":
                        answer = num1 * num2;
                        Console.WriteLine("Atsakymas: " + num1 + " * " + num2 + " = " + answer);
                        break;
                    case "/":
                        if (num1 != 0 && num2 != 0)
                        {
                            answer = num1 / num2;
                            Console.WriteLine("Atsakymas: " + num1 + " / " + num2 + " = " + answer);
                        }
                        else
                        {
                            Console.WriteLine("You can't divide from 0");
                        }
                        break;

                    case "+":
                        answer = num1 + num2;
                        Console.WriteLine("Atsakymas: " + num1 + " + " + num2 + " = " + answer);
                        break;
                    case "-":
                        answer = num1 - num2;
                        Console.WriteLine("Atsakymas: " + num1 + " - " + num2 + " = " + answer);
                        break;

                }
            


            //if (veiksmas == "X")
            //{
            //    answer = num1 * num2;
            //    Console.WriteLine("Atsakymas: " + num1 + " * " + num2 + " = " + answer);
            //}

            //else if (veiksmas == "+")
            //{
            //    answer = num1 + num2;
            //    Console.WriteLine("Atsakymas: " + num1 + " + " + num2 + " = " + answer);
            //}

            //else if (veiksmas == "/")
            //{
            //    answer = num1 / num2;
            //    Console.WriteLine("Atsakymas: " + num1 + " / " + num2 + " = " + answer);
            //}

            //else if (veiksmas == "-")
            //{
            //    answer = num1 - num2;
            //    Console.WriteLine("Atsakymas: " + num1 + " - " + num2 + " = " + answer);
            //}



        }
    }
}
