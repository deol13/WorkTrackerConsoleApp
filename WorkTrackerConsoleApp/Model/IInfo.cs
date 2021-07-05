using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Model
{
    interface IInfo
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //
        //public IInfo(int id, string name);

        const string INFOSTART = "----- info -----";
        string Info();
    }
}
