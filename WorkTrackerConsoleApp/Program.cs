using System;
using System.Collections.Generic;
using WorkTrackerConsoleApp.Model;

namespace WorkTrackerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(1, "Ulf" )); 
            people.Add(new Employee(2, "Kent", 123456 ));

            //LoopOverrideDif(people);
            EmployeeWorks();
        }

        static void EmployeeWorks()
        {
            Employee employee = new Employee(2, "Kent", 123456);

            employee.AddWorkTask("Code C#");
            employee.AddWorkTask("Make Coffe");
            employee.AddWorkTask("Drink Coffe");
            employee.AddWorkTask("Code C# faster/more");

            //foreach (string work in employee.WorkToDo())
            //{
            //    Console.WriteLine("Work with: " + work);
            //}

            //Console.WriteLine("\n------- boss work -------");

            Employee[] workers = new Employee[1];
            workers[0] = employee;

            Boss boss = new Boss(3, "Jonas", 123456, workers);

            boss.AddWorkTask("Code C#");
            boss.AddWorkTask("Make Coffe");
            boss.AddWorkTask("Drink Coffe");
            boss.AddWorkTask("Code C# faster/more");

            //foreach (string work in boss.WorkToDo())
            //{
            //    Console.WriteLine("Work with: " + work);
            //}

            List<Employee> employees = new List<Employee>() { employee, boss };

            foreach (Employee worker in employees)
            {
                Console.WriteLine(worker.Name);
                foreach (string work in worker.WorkToDo())
                {
                    Console.WriteLine("Work with: " + work);
                }
            }
        }

        static void LoopOverrideDif(List<Person> people)
        {
            Console.WriteLine("Just loop over people and get the Info");
            foreach (Person person in people)
            {
                Console.WriteLine(person.Info());
            }

            Console.WriteLine("\n\nLoop but check if Employee");
            foreach (Person person in people)
            {
                if (person is Employee)
                {
                    Console.WriteLine((person as Employee).Info());
                }
                else
                {
                    Console.WriteLine(person.Info());
                }
            }
        }
    }
}
