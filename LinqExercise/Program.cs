using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using System.Xml.Schema;

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
            var printer = new PrintArray(); 
            Console.WriteLine("Here is a list of numbers and a few things that we can do with them.\n");
            printer.Print(numbers);
            
            //TODO: Print the Sum of numbers
            Console.Write("\nThe sum of numbers in the list is: ");
            Console.WriteLine(numbers.Sum(x => x));

            //TODO: Print the Average of numbers
            Console.Write("\nThe average of the numbers in the list is: ");
            Console.WriteLine(numbers.Average(x => x));

            //TODO: Order numbers in ascending order and print to the console
            // if you need to keep ORIGINAL ORDER use OrderBy(); otherwise, use Sort() <- changes original array
            Console.WriteLine("\nThe list in ascending order is: \n");
            int[] numAscend = numbers.OrderBy(x => x).ToArray();
            printer.Print(numAscend);

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("\nThe list in descending order is: \n");
            int[] numDescend = numbers.OrderByDescending(x => x).ToArray();
            printer.Print(numDescend);

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("\nThese are the numbers greater than 6: \n");
            var greaterSix = numbers.Where(x => x > 6).ToArray();
            printer.Print(greaterSix);

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Add an employee to the end of the list without using employees.Add()


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
