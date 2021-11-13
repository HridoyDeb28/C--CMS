using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Entities
{
    class Product
    {
        public int Id { get; set; }
        public int ProductType { get; set; }
        public int Product_State { get; set; }
        public string Release_Date { get; set; }

        public string UpdateTime { get; set; }


        public int Receiving_Branch_id { get; set; }
        public int Sending_Branch_id { get; set; }
        public float Delivery_charge { get; set; }
        public int Sending_Manager_id { get; set; }
        public int Receiving_Manager_id { get; set; }
        public int ProductCategory { get; set; }
        public int PaymentMethod { get; set; }
        public string RecieverName { get; set; }
        public string RecieverEmail { get; set; }
        public string RecieverContact { get; set; }
        public string RecieverAddress { get; set; }
        public string Description { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public int Customer_MobileNo { get; set; }
    }
}
