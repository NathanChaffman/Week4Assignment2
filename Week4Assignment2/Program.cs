using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 4 Day 4 Assignment : Nathan Chaffman");
            Console.WriteLine();
            Console.WriteLine("What question would you like to tackle?");
            Console.WriteLine();
            Console.WriteLine("Type the appropriate number from the following:");
            Console.WriteLine();
            Console.WriteLine("     1 - 2D Array");
            Console.WriteLine("     2 - Jagged Little Array");
            Console.WriteLine("     3 - Overloaded Methods");
            Console.WriteLine("     4 - Overloaded Operators");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    regularArray();
                    break;
                case 2:
                    jaggedArray();
                    break;
                case 3:
                    overLoaded();
                    break;
                case 4:
                    operatorOverload();
                    break;
            }
        }
        static void overLoaded()
        {
            int a, b, c, choice, result;
            float d, e, f, result2;
            Console.WriteLine("choose from one of the following:");
            Console.WriteLine("     1. addition with two integers");
            Console.WriteLine("     2. addition with three integers");
            Console.WriteLine("     3. multiplication with two integers");
            Console.WriteLine("     4. multiplication with three integers");
            Console.WriteLine();
            Console.Write("Please make your selection: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Enter a value for a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = Add(a, b);
                    Console.WriteLine($"The solution is: {result}");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write("Enter a value for a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for c: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    result = Add(a, b, c);
                    Console.WriteLine($"The solution is: {result}");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write("Enter a value for a: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for b: ");
                    e = Convert.ToInt32(Console.ReadLine());
                    result2 = Multiply(d, e);
                    Console.WriteLine($"The solution is: {result2}");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.Write("Enter a value for a: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for b: ");
                    e = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a value for c: ");
                    f = Convert.ToInt32(Console.ReadLine());
                    result2 = Multiply(d, e, f);
                    Console.WriteLine($"The solution is: {result2}");
                    break;
            }
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static float Multiply(float a, float b)
        {
            return a * b;
        }
        static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
        static void regularArray()
        {
            Console.WriteLine("Let's make an array!");
            Console.WriteLine();
            Console.Write("First, tell me how many rows you want using natural numbers: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Next, tell me how many columns you want using natural numbers: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Enter the value for row {i + 1}, column {j + 1}: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Here is your Matrix, Neo:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"|{matrix[i, j]}|\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void jaggedArray()
        {
            Console.WriteLine("Let's make a jagged little array!");
            Console.WriteLine();
            Console.WriteLine("This array will display a student's associated grades.");
            Console.WriteLine();
            Console.WriteLine("First, tell me how many students there are using natural numbers: ");
            int numberOfstudents = Convert.ToInt32(Console.ReadLine());
            int numberOfsubjects;
            char[][] gradeArray = new char[numberOfstudents][];
            for (int i = 0; i < gradeArray.Length; i++)
            {
                Console.Write($"Enter the number of subjects for student {i + 1}: ");
                numberOfsubjects = Convert.ToInt32(Console.ReadLine());
                gradeArray[i] = new char[numberOfsubjects];
            }
            Console.WriteLine("Next, tell me the grades each student has in each subject using single characters only:");
            for (int i = 0; i < gradeArray.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: ");
                for (int j = 0; j < gradeArray[i].Length; j++)
                {
                    gradeArray[i][j] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Here are the grades for each student:");
            for (int i = 0; i < gradeArray.Length; i++)
            {
                Console.Write($"Student {i + 1}: " + "\t");
                for (int j = 0; j < gradeArray[i].Length; j++)
                {
                    Console.Write($"|{gradeArray[i][j]}|\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
        static void operatorOverload()
        {
            Console.Write("Choose 1 for addition or 2 for subtraction of area:");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    double result1;
                    Circle c1 = new Circle();
                    Console.WriteLine("Enter a radius for the first circle");
                    c1._radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a radius for the second circle");
                    Circle c2 = new Circle();
                    c2._radius = Convert.ToDouble(Console.ReadLine());
                    c1._area = Math.PI * c1._radius * c1._radius;
                    c2._area = Math.PI * c2._radius * c2._radius;
                    result1 = c1._area + c2._area;
                    Console.WriteLine($"The sum of the areas is : {result1}");
                    Console.ReadLine();
                    break;
                case 2:
                    double result2;
                    Circle c3 = new Circle();
                    Console.WriteLine("Enter a radius for the first circle");
                    c3._radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a radius for the second circle");
                    Circle c4 = new Circle();
                    c4._radius = Convert.ToDouble(Console.ReadLine());
                    c3._area = Math.PI * c3._radius * c3._radius;
                    c4._area = Math.PI * c4._radius * c4._radius;
                    result2 = Math.Abs(c3._area - c4._area);
                    Console.WriteLine($"The difference of the areas is : {result2}");
                    Console.ReadLine();
                    break;
            }
            
        }
    }
}

