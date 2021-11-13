using Final_Project.DataAccessLayer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Business_Layer
{
    class ProductService
    {
        ProductDataAccess pro;

        public ProductService()
        {
            this.pro = new ProductDataAccess();
        }


        public int AddParcel(int productType, int product_State, string release_Date, string updateTime, int receiving_Branch_id, int sending_Branch_id, float Delivery_charge, int sending_Manager_id, int receiving_Manager_id, int productCategory, int paymentMethod, string recieverName, string recieverEmail, string recieverContact, string recieverAddress, string description)
        {
            Product pr = new Product()
            {
                ProductType = productType,
                Product_State = product_State,
                Release_Date = release_Date,
                UpdateTime = updateTime,
                Receiving_Branch_id = receiving_Branch_id,
                Sending_Branch_id = sending_Branch_id,
                Delivery_charge = Delivery_charge,
                Sending_Manager_id = sending_Manager_id,
                Receiving_Manager_id = receiving_Manager_id,
                ProductCategory = productCategory,
                PaymentMethod = paymentMethod,
                RecieverName = recieverName,
                RecieverEmail = recieverEmail,
                RecieverContact = recieverContact,
                RecieverAddress = recieverAddress,
                Description = description

            };
            pro = new ProductDataAccess();
            return this.pro.AddNewParcel(pr);
        }

        public List<Product> getServiceHistory(int id)
        {
            return this.pro.getServiceHistory(id);
        }

        public List<Product> getShipAbleProducts(int id)
        {
            return this.pro.getShipAbleProducts(id);
        }
        public List<Product> getReleaseAbleProducts(int id)
        {
            return this.pro.getReleaseAbleProducts(id);
        }
        public List<Product> getReceiveAbleProducts(int id)
        {
            return this.pro.getReceiveAbleProducts(id);
        }

        public int ShipProduct(int id,int pid)
        {
            return this.pro.ShipProduct(id,pid);
        }
        public int ReleaseProduct(int pid)
        {
            return this.pro.ReleaseProduct(pid);
        }
        public int ReceiveProduct(int id,int pid)
        {
            return this.pro.ReceiveProduct(id,pid);
        }
    }
}
