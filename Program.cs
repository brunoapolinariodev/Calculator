using System;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("             CALCULATOR             ");
                Console.WriteLine("====================================");
                Console.WriteLine("1. 🧮 Sum");
                Console.WriteLine("2. ➖ Subtract");
                Console.WriteLine("3. ➗ Divide");
                Console.WriteLine("4. ✖️ Multiply");
                Console.WriteLine("5. 🚪 Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice number: ");
                short choice = short.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sum();
                        break;
                    case 2:
                        subtract();
                        break;
                    case 3:
                        divide();
                        break;
                    case 4:
                        multiply();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            static void sum()
            {
                Console.WriteLine("Enter the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("The sum of the two numbers is: " + (num1 + num2));
                Console.ReadKey();
                Menu();
            }

            static void subtract()
            {
                Console.WriteLine("Enter the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("The difference of the two numbers is: " + (num1 - num2));
                Console.ReadKey();
                Menu();
            }

            static void divide()
            {
                Console.WriteLine("Enter the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("The division of the two numbers is: " + (num1 / num2));
                Console.ReadKey();
                Menu();
            }
            static void multiply()
            {
                Console.WriteLine("Enter the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("The multiplication of the two numbers is: " + (num1 * num2));
                Console.ReadKey();
                Menu();
            }

        }
    }
}
