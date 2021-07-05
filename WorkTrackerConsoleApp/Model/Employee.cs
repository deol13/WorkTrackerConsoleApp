using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Model
{
    class Employee : Person
    {
        int salery;
        public int Salery { get { return salery; } set { salery = value; } }

        protected string[] workLoad;

        public Employee(int id, string name, int salery) : base(id, name)
        {
            workLoad = new string[0];
            Salery = salery;
        }

        public virtual string[] WorkToDo()
        {
            return workLoad;
        }

        public void AddWorkTask(string newTask)
        {
            Array.Resize(ref workLoad, workLoad.Length + 1);
            workLoad[^1] = newTask;
        }

        public new string Info()
        {
            return base.Info() + $"Salery: {salery} per/month\n";
        }
    }
}
