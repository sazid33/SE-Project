using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Database
    {
        //properties of server connection
        public string server = "localhost";
        public string userID = "root";
        public string password = "emon";


        //schema & table names
        public string schema = "pharmacy";
        public string doctor = "doctor";
        public string manufacturer = "manufacturer";
        public string medicine = "medicine";
        public string representative = "representative";
        public string sale = "sales";
        public string detail_sell = "detail_sale";
        public string customer = "customer";
        public string cart = "cart";

        //doctor table properties
        public string doc_ID = "ID";
        public string doc_name = "name";
        public string doc_designation = "designation";
        public string doc_speciality = "speciality";
        public string doc_contact = "contact";
        public string doc_address = "address";
        public string att_name = "att_name";
        public string att_contact1 = "att_con1";
        public string att_contact2 = "att_con2";

        //manufacturer table properties
        public string man_ID = "ID";
        public string man_name = "name";
        public string man_address = "address";
        public string man_shelf = "shelf";
        public string man_row = "row";
        public string del_name = "dealer_name";
        public string del_address = "dealer_address";
        public string del_con1 = "dealer_con1";
        public string del_con2 = "dealer_con2";

        //medicine table properties
        public string med_ID = "ID";
        public string med_name = "name";
        public string med_type = "type";
        public string med_manu = "manufacturer";
        public string weight = "weight";
        public string price = "price";
        public string quantity = "quantity";
        public string limit = "stock_limit";
        public string prescribed = "prescribed";

        //representative table properties
        public string rep_ID = "ID";
        public string rep_name = "name";
        public string rep_com = "company";
        public string rep_con1 = "con1";
        public string rep_con2 = "con2";
        public string rep_address = "address";

        //customer table properties
        public string cus_ID = "ID";
        public string cus_name = "name";
        public string cus_con1 = "contact1";
        public string cus_con2 = "contact2";
        public string cus_address = "address";
        public string cus_purchased = "total_purchased";
        public string cus_dues = "total_due";

        //sale table properties
        public string sale_ID = "ID";
        public string sale_cus_ID = "customer_ID";
        public string sale_doc_ID = "doctor_ID";
        public string sale_date = "date";
        public string sale_purchased = "total_purchased";
        public string sale_paid = "total_paid";
        public string sale_dues = "total_due";

        //detail sale table properties
        public string det_ID = "ID";
        public string det_sale_ID = "sales_ID";
        public string det_med_ID = "medicine_ID";
        public string det_amount = "amount_purchased";

        //cart table properties
        public string c_ID = "ID";
        public string c_type = "type";
        public string c_med = "medicine";
        public string c_weight = "weight";
        public string c_price = "price";
        public string c_quantity = "quantity";
    }
}
