using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is my example of arrays
            string[] names = new string[5] { "Ibrahim", "Michael", "Cesar", "Tyler", "Brennen" };
            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }
            
            // Other Needed Code
            ChildClass child = new ChildClass();
            child.print();

            Console.WriteLine("Enter your number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            int count = CountDivisions(number);
            Console.WriteLine($"Total number of divisions: {count}");
            Console.ReadKey();

            int first = 0;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());
            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");

            MyInformation.Ibrahim();
        }

        // Here is my example of Inheritance
        public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("Parent Constructor.");
            }

            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }
        // Here is my example of Inheritance (Cont)
        public class ChildClass : ParentClass
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
        }

        static int Divide(int first, int second)
        {
            int result = 0;
            
            // Here is my example of Try-Catch (Exception Handling)
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value.");
            }

            return result;
        }

        // Here is my example of  Recursion
        public static int CountDivisions(double number)
        {
            int count = 0;

            if (number > 0 && number % 2 == 0)
            {
                count++;
                number /= 2;

                return count += CountDivisions(number);
            }

            return count;
        }
    }

    // Here is my example of Classes
    class MyInformation
    {
        // Here is my example of Methods
        public static void Ibrahim()
        {
            string firstName = "Ibrahim";
            string lastName = "Jesri";
            string city = "Wichita";
            string state = "Kansas";
            int age = 18;
            string fullName = firstName + ' ' + lastName;

            Console.WriteLine($"{fullName} located in {city}, {state} is {age} years old!");
        }
    }
}