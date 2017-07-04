using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class Assignment3
    {

        public void Init()
        {
            Part1();
            Console.WriteLine();
            Part2();
            Console.WriteLine();
            Part3();
        }


        class Employee
        {
            int employeeNumber;
            String firstName;
            String lastName;
            
            public Employee(int employeeNum, string firstName, string lastName)
            {
                this.employeeNumber = employeeNum;
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public static void LogEmployee(Employee e)
            {
                Console.WriteLine();
                Console.WriteLine(e.employeeNumber);
                Console.WriteLine(e.firstName);
                Console.WriteLine(e.lastName);
            }

            public int EmployeeNumber
            {
                get { return employeeNumber; }
                internal set { employeeNumber = value; }
            }
        }

        private void Part1()
        {
            Employee e1 = new Employee(192837465, "Joe", "Blow");
            Employee e2 = new Employee(987654321, "MIchael", "Scott");
            Employee e3 = new Employee(123456789, "Susan", "Krant");

            Employee[] employees = new Employee[3];

            employees[0] = e1;
            employees[1] = e2;
            employees[2] = e3;

            Console.WriteLine("UNSORTED: ");
            for (int i = 0; i < employees.Length; i++)
            {
                Employee.LogEmployee(employees[i]);
            }

            Console.WriteLine();

            SortEmployees(ref employees);


            Console.WriteLine();
            Console.WriteLine("SORTED: ");
            for (int i = 0; i < employees.Length; i++)
            {
                Employee.LogEmployee(employees[i]);
            }
        }

        private void SortEmployees(ref Employee[] data)
        {
            for (int i = 0; i <= data.Length - 1; i++)
            {
                var current = data[i];
                int j = i - 1;

                while (j >= 0 && data[j].EmployeeNumber > current.EmployeeNumber)
                {
                    data[j + 1] = data[j];
                    j--;
                }

                data[j + 1] = current;
            }
        }

        private void Part2()
        {
            Console.Write("Enter a word: ");
            string check = Console.ReadLine();
            bool res = HasDuplicateChars(check);
            Console.WriteLine(res);
        }

        private bool HasDuplicateChars(string s)
        {
            bool result = false;

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i + 1; j < s.Length - 1; j++)
                {
                    if(s[i] == s[j])
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        private void Part3()
        {

        }

        private bool IsAnagram(string s1, string s2)
        {
            bool result = false;

            

            return result;
        }
    }
}
