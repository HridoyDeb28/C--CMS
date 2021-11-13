using Final_Project.DataAccessLayer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Business_Layer
{
    class UserService
    {
        UsersDataAccess ud;

        public UserService()
        {
            this.ud = new UsersDataAccess();
        }


        public int InsertUsers(string userName, string password, string emailAddress, int userType, bool information_given)
        {
            Users us = new Users()
            {
                UserName = userName,
                Password = password,
                EmailAddress = emailAddress,
                UserType = userType,
                Information_given = information_given
            };
            ud = new UsersDataAccess();
            return this.ud.InsertUsers(us);
        }

        public int getIdByUserName(string userName)
        {
            return this.ud.GetIdByUsername(userName);
        }

        public int DeleteUser(int id)
        {
            return this.ud.DeleteUsers(id);
        }

        public Users Validate(string uname,string pass)
        {
            return this.ud.Validate(uname, pass);
        }

        public List<Users> GetUsersData()
        {
            return this.ud.GetAllUsers();
        }
    }
}
