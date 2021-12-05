using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Workers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public string phoneNumber { get; set; }



        public Workers(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
            return $"{surname} {name}";
        }
               
    }
}
