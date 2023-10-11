using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum: {numbers.Sum()}");


            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending:");
            foreach (var n in numbers.OrderBy(num => num))
                Console.Write(n + " ");

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("\nDescending:");
            foreach (var n in numbers.OrderByDescending(num => num))
                Console.Write(n + " ");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("\nGreater than 6:");
            foreach (var n in numbers.Where(num => num > 6))
                Console.Write(n + " ");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("\nAny 4 numbers:");
            foreach (var n in numbers.Take(4))
                Console.Write(n + " ");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers[4] = 22;
            Console.WriteLine("\nDescending after changing index 4:");
            foreach (var n in numbers.OrderByDescending(num => num))
                Console.Write(n + " ");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("\nEmployees whose first name starts with C or S:");
            foreach (var e in employees.Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S")).OrderBy(e => e.FirstName))
                Console.WriteLine(e.FullName);

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("\nEmployees over 26 years old:");
            foreach (var e in employees.Where(e => e.Age > 26).OrderBy(e => e.Age).ThenBy(e => e.FirstName))
                Console.WriteLine($"{e.FullName} {e.Age}");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var employeesFiltered = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);
            Console.WriteLine($"Sum of YearsOfExperience: {employeesFiltered.Sum(e => e.YearsOfExperience)}");
            Console.WriteLine($"Average of YearsOfExperience: {employeesFiltered.Average(e => e.YearsOfExperience)}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Concat(new List<Employee> { new Employee("John", "Doe", 30, 5) }).ToList();


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
