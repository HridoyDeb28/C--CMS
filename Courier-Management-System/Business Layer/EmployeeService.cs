using Final_Project.DataAccessLayer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Business_Layer
{
    class EmployeeService
    {
        EmployeeDataAccess emp;

        public EmployeeService()
        {
            this.emp = new EmployeeDataAccess();
        }

        public int AddEmployee(string name, string joining_date, string dob, float salary, float bonus, string contact, string address, int designation, int branch_id, string blood_Group,int userid)
        {
            Employee em = new Employee()
            {
                Name = name,
                Joining_date = joining_date,
                DOB = dob,
                Salary = salary,
                Bonus = bonus,
                Contact = contact,
                Address = address,
                Designation = designation,
                Branch_id = branch_id,
                Blood_Group = blood_Group,
                UserId = userid
            };
            emp = new EmployeeDataAccess();
            return this.emp.AddEmployees(em);

        }

        public int GetBranchId(int id)
        {
            return this.emp.getBranchId(id);
        }

        public Employee GetEmployee(int id)
        {
            return this.emp.GetEmployee(id);
        }

        public List<Employee> GetEmployeeData()
        {
            return this.emp.GellAllEmployessData();
        }

        public int UpdateEmployeeName(int id, string employeeName)
        {
            Employee en = new Employee()
            {
                Id = id,
                Name = employeeName
            };
            return this.emp.UpdateEmployeeName(en);

        }

        public int Update(Employee employee)
        {
           return this.emp.Update(employee);
        }

        public int UpdateEmployeeSalary(int id, float employeeSalary)
        {
            Employee en = new Employee()
            {
                Id = id,
                Salary = employeeSalary,
            };
            return this.emp.UpdateEmployeeName(en);

        }


        public int UpdateEmployeeContact(int id, string employeeContact)
        {
            Employee en = new Employee()
            {
                Id = id,
                Contact = employeeContact
            };
            return this.emp.UpdateEmployeeName(en);

        }


        public int UpdateEmployeeAddress(int id, string updateEmployeeAddress)
        {
            Employee en = new Employee()
            {
                Id = id,
                Address = updateEmployeeAddress
            };
            return this.emp.UpdateEmployeeName(en);

        }

        public int DeleteEmployee(int id)
        {
            return this.emp.DeleteEmployee(id);
        }
    }
}
