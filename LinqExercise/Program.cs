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
            var ascend = numbers.OrderBy(x => x).ToArray();
            printer.Print(ascend);

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("\nThe list in descending order is: \n");
            var descend = numbers.OrderByDescending(x => x).ToArray();
            printer.Print(descend);

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("\nThese are the numbers greater than 6: \n");
            var aboveSix = numbers.OrderBy(x => x > 6).ToArray();
            printer.Print(aboveSix);

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("\nPrinting only 4 numbers in the acsending list:\n");
            foreach (var x in ascend.Take(4))
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 41;
            Console.WriteLine("\nReplacing the 4th value with my age and then writing in descending order.\n");
            var newDescend = numbers.OrderByDescending(x => x).ToArray();
            printer.Print(newDescend);

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filterFirst = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName);
            Console.WriteLine("\nA list of employees whose first name starts with C or S in ascending order.\n");
            foreach (var employee in filterFirst)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("\nA list of employees over the age of 26 ordered by age and then first name.\n");
            var ageName = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in ageName)
            {
                Console.WriteLine($"Name: {employee.FullName}\nAge: {employee.Age}"); 
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("\nThe sum and average of employees' Years of Experience if YoE is less than 11 and Age is greater than 35.\n");
            var yoeAge = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"The sum of years of experience is: {yoeAge.Sum(x=>x.YearsOfExperience)}");
            Console.WriteLine($"The average of the years of experience is: {yoeAge.Average(x=>x.YearsOfExperience)}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Robert", "Rogers", 41, 1)).ToList();
            Console.WriteLine("An appended list with one new employee.");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.FullName}"); 
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"YoE: {employee.YearsOfExperience}");
            }

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
