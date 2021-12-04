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

        public WorkPlaces(string name, string livingPlace, string singleMoneyLimit, string doubleleMoneyLimit, string travelMoney)
        {
            this.name = name; 
            this.livingPlace = livingPlace;
            this.singleMoneyLimit = singleMoneyLimit;
            this.DoubleleMoneyLimit = doubleleMoneyLimit;
            this.travelMoney = travelMoney;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
