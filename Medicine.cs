using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Medicine
    {
        public int ID;
        public string name;
        public string type;
        public string manufacturer;
        public string weight;
        public double price = 0.00;
        public int quantity;
        public int stock_limit;
        public int prescribed;

        public int manu_shelf;
        public int manu_row;
    }
}
