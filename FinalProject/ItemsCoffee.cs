using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ItemsCoffee
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


        public ItemsCoffee(string number, string name, int price)
        {
            Number = number;
            Name = name;
            Price = price;
        }
    }
}
