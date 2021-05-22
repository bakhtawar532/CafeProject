using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DealCoffee
    {
        public int id { get; set; }
        public string item_name { get; set; }
        public int total_price { get; set; }


        public DealCoffee(int id, string item_name, int total_price)
        {
            this.id = id;
            this.item_name = item_name;
            this.total_price = total_price;

        }
    }
}
