using Final_Project.DataAccessLayer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Business_Layer
{
    class BranchService
    {
        BranchDataAccess bd;

        public BranchService()
        {
            this.bd = new BranchDataAccess();
        }

        public int InsertBranch(string branch_Name, string address)
        {
            Branch br = new Branch()
            {
                Branch_Name = branch_Name,
                Address = address
            };
            bd = new BranchDataAccess();
            return this.bd.InsertBranch(br);
        }

        public int DeletBranch(int id)
        {
            return this.bd.DeleteBranch(id);
        }

        public List<Branch> GetBranchData()
        {
            return this.bd.GetAllBranch();
        }

        public int UpdateBranchName(string address, string branchName)
        {
            Branch br = new Branch()
            {
                Address = address,
                Branch_Name = branchName
            };
            return this.bd.UpdateBranch(br);

        }

    }
}
