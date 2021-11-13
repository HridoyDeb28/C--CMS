using Final_Project.DataAccessLayer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Business_Layer
{
    class EmployeeProblemService
    {
        Employee_ProblemDataAccess ep;

        public EmployeeProblemService()
        {
            this.ep = new Employee_ProblemDataAccess();
        }



        public int InsertBranchProblem(string problem, int user_id)
        {
            EmployeeService employeeService = new EmployeeService();
            Employee_Problem epp = new Employee_Problem()
            {
                Problem = problem,
                User_id = user_id,
                Branch_id = employeeService.GetBranchId(user_id)
            };

            ep = new Employee_ProblemDataAccess();
            return this.ep.InsertProblem(epp);

        }


        public int DeleteProblem(int id)
        {
            return this.ep.DeleteProblem(id);
        }

        public int UpdateProblemName(int id, string problemName)
        {
            Employee_Problem e = new Employee_Problem()
            {
                User_id = id,
                Problem = problemName,
            };
            return this.ep.UpdateProblem(e);

        }

        public List<Employee_Problem> GetEmployeeProblemData()
        {
            return this.ep.GetEmployeeProblemData();
        }
    }
}
