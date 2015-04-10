
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao :IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees =new  List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "mumu";
            employees1.Name = "畝畝";
            employees1.Age = 1;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "jonjon";
            employees2.Name = "將將";
            employees2.Age = 2;
            employees.Add(employees2);


            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id="1101137106";
            employees.Name="黃婷瑋";
            employees.Age=21;
            return employees;
        }

    }
}
