using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C_Sharp.Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Console.WriteLine("Task 1");
            Console.Write("Please, enter digit between 1 and 100: ");
            int num1 = Int32.Parse(Console.ReadLine());
            if (num1 < 1 || num1 > 100) { Console.WriteLine("Please, enter correct number"); }
            else if (num1 % 3 == 0 && num1 % 5 == 0) { Console.WriteLine("FizzBuzz"); }
            else if (num1 % 5 == 0) { Console.WriteLine("Buzz"); }
            else if (num1 % 3 == 0) { Console.WriteLine("Fizz"); }
            else { Console.WriteLine(num1); }

            // Task 2

            Console.WriteLine("\nTask 2");
            Console.Write("Please, enter number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please, enter percent: ");
            double percent = Int32.Parse(Console.ReadLine());
            double result2 = Convert.ToDouble(num1 * percent / 100);
            Console.WriteLine($"{percent} % from {num1} is: {result2}");

            // Task 3

            int digit1, digit2, digit3, digit4, total;
            Console.WriteLine("\nTask 3");
            Console.WriteLine("Enter 4 digits: ");
            Console.Write("Digit1: ");
            digit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digit2: ");
            digit2 = Int32.Parse(Console.ReadLine());
            Console.Write("Digit3: ");
            digit3 = Int32.Parse(Console.ReadLine());
            Console.Write("Digit4: ");
            digit4 = Int32.Parse(Console.ReadLine());


            total = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
            Console.WriteLine($"You digit:{total} ");

            // Task 4

            Console.WriteLine("\nTask 4");
            Console.Write("Enter 6-digit number: ");
            int temp1, temp2, temp3, temp4, temp5, temp6, result = 0, rate1, rate2;
            int sixDigit = Int32.Parse(Console.ReadLine());
            if (sixDigit < 99999 || sixDigit > 999999)
                Console.WriteLine("Erorr");
            Console.WriteLine("Enter 1st digit to exchange the rate: ");
            rate1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd digit to exchange the rate: ");
            rate2 = Int32.Parse(Console.ReadLine());
            temp1 = sixDigit / 100000;
            temp2 = (sixDigit / 10000) - (temp1 * 10);
            temp3 = (sixDigit / 1000) - ((temp1 * 100) + (temp2 * 10));
            temp4 = (sixDigit / 100) - ((temp1 * 1000) + (temp2 * 100) + (temp3 * 10));
            temp5 = (sixDigit / 10) - ((temp1 * 10000) + (temp2 * 1000) + (temp3 * 100) + (temp4 * 10));
            temp6 = sixDigit -
            ((temp1 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp5 * 10));
            Console.WriteLine($"{temp1} {temp2} {temp3} {temp4} {temp5} {temp6}");

            // Numbers with 1
            if ((rate1 == 1 && rate2 == 6) || (rate1 == 6 && rate2 == 1))
            {
                result = ((temp6 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp5 * 10) + temp1);
            }

            if ((rate1 == 1 && rate2 == 5) || (rate1 == 5 && rate2 == 1))
            {
                result = ((temp5 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp1 * 10) + temp6);
            }

            if ((rate1 == 1 && rate2 == 4) || (rate1 == 4 && rate2 == 1))
            {
                result = ((temp4 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp1 * 100) + (temp5 * 10) + temp6);
            }

            if ((rate1 == 1 && rate2 == 3) || (rate1 == 3 && rate2 == 1))
            {
                result = ((temp3 * 100000) + (temp2 * 10000) + (temp1 * 1000) + (temp4 * 100) + (temp5 * 10) + temp6);
            }
            if ((rate1 == 1 && rate2 == 2) || (rate1 == 2 && rate2 == 1))
            {
                result = ((temp2 * 100000) + (temp1 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp5 * 10) + temp6);
            }

            // Numbers with 2
            if ((rate1 == 2 && rate2 == 5) || (rate1 == 5 && rate2 == 2))
            {
                result = ((temp1 * 100000) + (temp5 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp2 * 10) + temp6);
            }

            if ((rate1 == 2 && rate2 == 3) || (rate1 == 3 && rate2 == 2))
            {
                result = ((temp1 * 100000) + (temp3 * 10000) + (temp2 * 1000) + (temp4 * 100) + (temp5 * 10) + temp6);
            }

            if ((rate1 == 2 && rate2 == 4) || (rate1 == 4 && rate2 == 2))
            {
                result = ((temp1 * 100000) + (temp4 * 10000) + (temp3 * 1000) + (temp2 * 100) + (temp5 * 10) + temp6);
            }
            if ((rate1 == 2 && rate2 == 6) || (rate1 == 6 && rate2 == 2))
            {
                result = ((temp1 * 100000) + (temp6 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp5 * 10) + temp2);
            }

            // Numbers with 3
            if ((rate1 == 3 && rate2 == 4) || (rate1 == 4) && (rate2 == 3))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp4 * 1000) + (temp3 * 100) + (temp5 * 10) + temp6);
            }

            if ((rate1 == 3 && rate2 == 5) || (rate1 == 5 && rate2 == 3))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp5 * 1000) + (temp4 * 100) + (temp3 * 10) + temp6);
            }

            if ((rate1 == 3 && rate2 == 6) || (rate1 == 6 && rate2 == 3))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp6 * 1000) + (temp4 * 100) + (temp5 * 10) + temp3);
            }

            // Numbers with 4

            if ((rate1 == 4 && rate2 == 5) || (rate1 == 5 && rate2 == 4))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp5 * 100) + (temp4 * 10) + temp6);
            }

            if ((rate1 == 4 && rate2 == 6) || (rate1 == 6 && rate2 == 4))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp6 * 100) + (temp5 * 10) + temp4);
            }


            // Numbers with 5

            if ((rate1 == 5 && rate2 == 6) || (rate1 == 6 && rate2 == 5))
            {
                result = ((temp1 * 100000) + (temp2 * 10000) + (temp3 * 1000) + (temp4 * 100) + (temp6 * 10) + temp5);
            }

            Console.WriteLine($"Result: {result}");

            // Task 5

            Console.WriteLine("\nTask 5");
            DateTime date1;
            string input;

            // Reading Date

            do
            {
                Console.WriteLine("Please, enter the date(22.12.2022):");
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out date1));

            Console.WriteLine($"My date: {date1}");

            // Reading date

            int month = date1.Month;

            Console.WriteLine($"My month: {month}");

            // Writing time of year

            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine($"It's winter time {date1.DayOfWeek}");
            }
            if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine($"It's spring time {date1.DayOfWeek}");
            }
            if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine($"It's summer time {date1.DayOfWeek}");
            }
            if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine($"It's autumn time {date1.DayOfWeek}");
            }

            // Task 6

            Console.WriteLine("\nTask 6");
            Console.WriteLine("\nEnter Farenheit(0) or Celsius(1)");
            int choise = Int32.Parse(Console.ReadLine());
            //Boolean.TryParse(Console.ReadLine(), out choise);
            //double Celsius, Farenheit;

            Console.WriteLine(choise);

            if (choise == 1)
            {
                Console.Write("Please, enter number(Celsius): ");
                double Celsuis = double.Parse(Console.ReadLine());
                double Farenheit = (Celsuis * 1.8) + 32;
                Console.WriteLine($"Farenheit: {Farenheit}");
            }
            else
            {
                Console.Write("Please, enter number(Farenheit): ");
                double Farenheit = double.Parse(Console.ReadLine());
                double Celsius = (Farenheit - 32) / 1.8;
                Console.WriteLine($"Celsius: {Celsius}");
            }

            // Task 7

            Console.WriteLine("\nTask 7");
            Console.Write("\nEnter number1: ");
            int num3 = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter number2: ");
            int num2 = Int32.Parse(Console.ReadLine());

            // Normalization
            if (num3 > num2)
            {
                int temp = num2;
                num2 = num3;
                num3 = temp;
            }

            Console.WriteLine($"Num1: {num3} Num2: {num2}");

            for (int i = num3; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
