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
          

            //Done: Print the Sum of numbers

            Console.WriteLine(numbers.Sum());

            //Done: Print the Average of numbers

            Console.WriteLine(numbers.Average());

            //Done: Order numbers in ascending order and print to the console

            var ascendingOrder = numbers.OrderBy(item => item);

            foreach (var item in ascendingOrder)
            {
                Console.WriteLine(item);
            }

            //Done: Order numbers in descending order and print to the console

            var descendingOrder = numbers.OrderByDescending(item => item);

            foreach (var item in descendingOrder)
            {
                Console.WriteLine(item);
            }

            //Done: Print to the console only the numbers greater than 6

            var greaterSix = numbers.Where(num => num > 6);

            foreach (var item in greaterSix)
            {
                Console.WriteLine(item);
            }

            //Done: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            foreach (var item in descendingOrder.Take(4))
            {
                Console.WriteLine(item);
            }
            //Done: Change the value at index 4 to your age, then print the numbers in descending order

            numbers.SetValue(41, 4);

            var descendingAge = numbers.OrderByDescending(num => num);

            foreach (var item in descendingAge)
            {
                Console.WriteLine(item);
            }
            // List of employees ****Do not remove this****

            var employees = CreateEmployees();

            //Done: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's');

            foreach (var person in filtered)
            {
                Console.WriteLine(person.FullName);
            }

            //Done: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var twentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);

            foreach (var item in twentySix)
            {
                Console.WriteLine($"Full Name: {item.FullName} Age: {item.Age}");
            }

            //Done: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var sumWithYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine($"Years Of Experience: {sumWithYOE.Sum(x => x.YearsOfExperience)}");

            //Done: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine($"Average Years Of Experience: {sumWithYOE.Average(x => x.YearsOfExperience)}");

            //Done: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("John", "Doe", 39, 15)).ToList();

            foreach (var item in employees)
            { 
                Console.WriteLine(item.FullName);
            }
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
