using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Model
{
    class Boss : Employee
    {
        Employee[] manageEmployees;

        public Boss(int id, string name, int salery, Employee[] manageEmployees) : base(id, name, salery)
        {
            this.manageEmployees = manageEmployees;
        }

        public override string[] WorkToDo()
        {
            string[] workdToDo = new string[workLoad.Length];
            workLoad.CopyTo(workdToDo, 0);
            Array.Resize(ref workdToDo, workdToDo.Length + manageEmployees.Length);

            int index = workLoad.Length;
            foreach (Employee employee in manageEmployees)
            {
                workdToDo[index++] = "Manage: " + employee.Name;
                //index++;
            }

            return workdToDo;
        }
    }
}
