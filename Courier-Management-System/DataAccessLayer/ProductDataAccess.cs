using Final_Project.Business_Layer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccessLayer
{
    class ProductDataAccess
    {
        DataAccess dataAccess;
        public ProductDataAccess()
        {
            this.dataAccess = new DataAccess();
        }


        public int AddNewParcel(Product products)
        {
            string sql = "INSERT INTO Product(ProductType,Receiving_B_id,Sending_B_id,Delivery_charge,Receiving_Manager_id,UpdatedDate,Sending_Manager_id,ProductCategory,PaymentMethod,RecieverName,RecieverEmail,RecieverContact,RecieverAddress,Description,Product_State,Release_Date) VALUES('" + products.ProductType + "','" + products.Receiving_Branch_id + "','" + products.Sending_Branch_id + "','" + products.Delivery_charge + "','" + products.Receiving_Manager_id + "','" + products.UpdateTime + "','" + products.Sending_Manager_id + "','" + products.ProductCategory + "','" + products.PaymentMethod + "','" + products.RecieverName + "','" + products.RecieverEmail + "','" + products.RecieverContact + "','" + products.RecieverAddress + "','" + products.Description + "','" + products.Product_State + "','" + products.Release_Date + "')";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public List<Product> getServiceHistory(int id)
        {
            string sql = "select * from Product where (Sending_Manager_id = '"+id+"' or Receiving_Manager_id = '"+id+"') and Product_State = 4";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Id = (int)reader["Id"];
                p.ProductType = (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = float.Parse(reader["Delivery_charge"].ToString());
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                pro.Add(p);

            }
            return pro;
        }

        public List<Product> getShipAbleProducts(int id)
        {
            EmployeeService es = new EmployeeService();
            int bid = es.GetBranchId(id);
            string sql = "select * from Product where Sending_B_id = '"+bid+"' and Product_State = 1";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Id = (int)reader["Id"];
                p.ProductType = (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = float.Parse(reader["Delivery_charge"].ToString());
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                pro.Add(p);

            }
            return pro;
        }

        public List<Product> getReleaseAbleProducts(int id)
        {
            EmployeeService es = new EmployeeService();
            int bid = es.GetBranchId(id);
            string sql = "select * from Product where Receiving_B_id = '" + bid + "' and Product_State = 3";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Id = (int)reader["Id"];
                p.ProductType = (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = float.Parse(reader["Delivery_charge"].ToString());
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                pro.Add(p);

            }
            return pro;
        }

        public List<Product> getReceiveAbleProducts(int id)
        {
            EmployeeService es = new EmployeeService();
            int bid = es.GetBranchId(id);
            string sql = "select * from Product where Receiving_B_id = '" + bid + "' and Product_State = 2";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Id = (int)reader["Id"];
                p.ProductType = (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = float.Parse(reader["Delivery_charge"].ToString());
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                pro.Add(p);

            }
            return pro;
        }

        public List<Product> GellAllData()
        {
            string sql = "SELECT * FROM Product";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Product> pro = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Id = (int)reader["Id"];
                p.ProductType = (int)reader["ProductType"];
                p.Receiving_Branch_id = (int)reader["Receiving_B_id"];
                p.Sending_Branch_id = (int)reader["Sending_B_id"];
                p.Delivery_charge = float.Parse(reader["Delivery_charge"].ToString());
                p.Receiving_Manager_id = (int)reader["Receiving_Manager_id"];
                p.UpdateTime = reader["UpdatedDate"].ToString();
                p.Sending_Manager_id = (int)reader["Sending_Manager_id"];
                p.ProductCategory = (int)reader["ProductCategory"];
                p.PaymentMethod = (int)reader["PaymentMethod"];
                p.RecieverName = reader["RecieverName"].ToString();
                p.RecieverEmail = reader["RecieverEmail"].ToString();
                p.RecieverContact = reader["RecieverContact"].ToString();
                p.RecieverAddress = reader["RecieverAddress"].ToString();
                p.Description = reader["Description"].ToString();
                p.Product_State = (int)reader["Product_State"];
                p.Release_Date = reader["Release_Date"].ToString();
                pro.Add(p);

            }
            return pro;
        }

        public int ShipProduct(int id, int pid)
        {
            string sql = "UPDATE Product SET Product_State= 2, Sending_Manager_id ="+id+" WHERE Id=" + pid;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int ReceiveProduct(int id, int pid)
        {
            string sql = "UPDATE Product SET Product_State= 3, Receiving_Manager_id ="+id+" WHERE Id=" + pid;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int ReleaseProduct(int pid)
        {
            string sql = "UPDATE Product SET Product_State= 4 WHERE Id=" + pid;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
 }
