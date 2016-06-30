using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public string NameCapitalized
        {
            get
            {
                return Name.ToTitleCase();
            }
        }
        public string SectorCapitalized
        {
            get
            {
                return Sector.ToTitleCase();
            }
        }
    }
}
