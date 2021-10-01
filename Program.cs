using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad
{
    class Program
    {
        static void Main(string[] args)
        {




            //declaration of data type
            // bool result;
            // string name1 = "MilagroScardigno";
            // result = Char.IsWhiteSpace(name1, 2);
            // Console.WriteLine(result);

            // string name2 = "Milagro Scardigno";
            // result = Char.IsWhiteSpace(name2, 7);
            // Console.WriteLine(result);

            // var sentence = "today is friday";
            // var words = sentence.Contains(" ");
            // Console.WriteLine(words);
            // string fullName = "Milagro Scardigno";
            // char[] delimiter = new char[] { ' ' };
            // foreach (var name in fullName.Split(" ").Reverse())
            // {
            //     // Console.WriteLine(name);
            //     var reversedName = name.Reverse();
            //     Console.WriteLine(name);
            // }
            // string name = "Milagro Scardigno";
            // name = string.Join(" ", name.Split(' ').Reverse()).Trim();
            // Console.WriteLine(name);
            // string name1 = "McClane john";
            // string name2 = "jeggins Mary";
            // string name3 = "jerry tom";
            // var names = new List<string> { };
            // Console.WriteLine(string.Join(" ", name1.Split(' ').Reverse()).Trim());
            // Console.WriteLine(string.Join(" ", name2.Split(' ').Reverse()).Trim());
            // Console.WriteLine(string.Join(" ", name3.Split(' ').Reverse()).Trim());
            // Console.ReadLine();
            // // Console.WriteLine(name.Select((character, index) => $"The character at index {index} is {character}."));
            // Console.ReadLine();
            // Console.WriteLine("Please enter your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // if (age > 0)
            // {
            //     if (age > 18)
            //     {
            //         Console.WriteLine("You are 18 years and older.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Ypu are a minor.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Age cannot be a negative number.");
            // }
            Console.WriteLine("Select an option to perform: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            int selectedOption = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // switch (selectedOption)
            // {
            //     case (1):
            //         int sum = num1 + num2;
            //         Console.WriteLine($"The sum of the two numbers you entered {num1} and {num2} is equal to {sum}");
            //         break;
            //     case (2):
            //         int substraction = num1 - num2;
            //         Console.WriteLine($"The substraction of the two numbers you entered {num1} and {num2} is equal to {substraction}");
            //         break;
            //     default:
            //         Console.WriteLine("Incorrect option. Please try again.");
            //         Console.ReadKey();
            //         return;
            // }
            if (selectedOption == 1)
            {
                int sum = num1 + num2;
                Console.WriteLine($"The sum of the two numbers you entered is equal to: {sum}");
            }
            else if (selectedOption == 2)
            {
                int substraction = num1 - num2;
                Console.WriteLine($"The substraction of the two numbers you entered is equal to: {substraction}");
            }
            else
            {
                Console.WriteLine("Incorrect option.");
            }

            Console.ReadKey();
        }

    }
}
