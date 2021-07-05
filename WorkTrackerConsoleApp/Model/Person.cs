using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Model
{
    class Person : IInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Info()
        {
            return $"{IInfo.INFOSTART}\nID: {Id}\nName: {Name}\n";
        }
    }
}