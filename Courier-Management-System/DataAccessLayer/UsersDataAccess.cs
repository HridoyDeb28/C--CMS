using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccessLayer
{
    class UsersDataAccess
    {
        
        DataAccess dataAccess;
        public UsersDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public Users Validate(string username, string password)
        {
            string sql = "SELECT * FROM Users where UserName='"+username+"' and Password ='"+password+"'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            while (reader.Read())
            {
                Users users = new Users();
                users.Id = (int)reader["Id"];
                users.UserName = reader["UserName"].ToString();
                users.Password = reader["Password"].ToString();
                users.EmailAddress = reader["EmailAddress"].ToString();
                users.UserType = (int)reader["UserType"];
                users.Information_given = (bool)reader["Information_given"];
                return users;
            }
            return null;
        }

        public int GetIdByUsername(string userName)
        {
            string sql = "SELECT Id FROM Users where UserName='" + userName+"'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return (int)reader["Id"];
        }
        public List<Users> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Users> users1 = new List<Users>();
            while (reader.Read())
            {
                Users users = new Users();
                users.UserName = reader["UserName"].ToString();
                users.Password = reader["Password"].ToString();
                users.EmailAddress = reader["EmailAddress"].ToString();
                users.UserType = (int)reader["UserType"];
                users.Information_given =(bool) reader["Information_given"];
               // users.Add(users);
            }
            return users1;
        }
        public Users GetUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Users users = new Users();
            users.UserName = reader["UserName"].ToString();
            users.Password = reader["Password"].ToString();
            users.EmailAddress = reader["EmailAddress"].ToString();
            users.UserType = (int)reader["UserType"];
            users.Information_given = (bool)reader["Information_given"];
            return users;
        }
        public int InsertUsers(Users users)
        {
            string sql = "INSERT INTO Users(UserName,Password,EmailAddress,UserType,Information_given) VALUES('" + users.UserName + "','" + users.Password + "','" + users.EmailAddress + "','" + users.UserType + "','"+users.Information_given+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteUsers(int id)
        {
            string sql = "DELETE FROM Users WHERE Id=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

    }
    
  





}
