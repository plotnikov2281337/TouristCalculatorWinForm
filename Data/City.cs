using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCalculatorWinForm.Data
{
    internal class City
    {
        string name;
        int price;
        int transit;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Transit { get => transit; set => transit = value; }
    }
}
