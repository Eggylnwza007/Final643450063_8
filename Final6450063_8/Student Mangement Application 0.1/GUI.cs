using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace record
{
    internal class GUI
    {   
        public string Namelist { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public GUI (string namelist, double amount, string type)
        {
            Namelist = namelist;
            Amount = amount;
            Type = type;
        }
    }
}