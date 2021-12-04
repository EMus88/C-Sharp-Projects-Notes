using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class WorkPlaces
    {
        public string name { get; set; }
        public string livingPlace { get; set; }
        public string singleMoneyLimit { get; set; }
        public string DoubleleMoneyLimit { get; set; }
        public string travelMoney { get; set; }

        public WorkPlaces(string name)
        {
            this.name = name; 
            
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
