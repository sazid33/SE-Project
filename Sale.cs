using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Sale
    {
        public int ID;
        public int cus_ID;
        public string cus_name;
        public int doc_ID;
        public string doc_name;
        public string date;
        public double total_purchased;
        public double total_paid;
        public double total_due;
    }
}
