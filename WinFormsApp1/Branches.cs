using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Branches
    {

        public string name { get; set; }
        public int id { get; set; }
        public List<WorkPlaces> listPlaces = new();

        public Branches(string name)
        {
            this.name = name;

        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
