using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Models;
using DataAccessLayer;

namespace BusinessLayer
{
    public class EmployeeBL
    {
        public void AddEmployee(Employee employee)
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                dbcontext.Employees.Add(employee);
                dbcontext.SaveChanges();
            } 
        }
        public void UpdateEmployee(Employee employee)
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
                if (emp == null)
                    return;
                emp.Name = employee.Name;
                emp.Birthdate = employee.Birthdate;
                emp.Age = employee.Age;
                emp.Gender = employee.Gender;
                emp.Status = employee.Status;
                emp.Skills = employee.Skills;
                emp.Job = employee.Job;
                emp.Department = employee.Department;
                emp.Arabic = employee.Arabic;
                emp.English = employee.English;
                dbcontext.SaveChanges();
            }   
        }
        public void DeleteEmployee(int id)
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.Id == id).FirstOrDefault();
                if (emp != null)
                {
                    dbcontext.Employees.Remove(emp);
                    dbcontext.SaveChanges();
                }
            }
        }
        public Employee GetEmployeeById(int employeeId)
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.Id == employeeId).FirstOrDefault(); ;
                return emp;
            }
        }

        public int GetEmployeeCount() {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.EmployeeType == "Employee").ToList();
                return emp.Count;
            }
        }
        public int GetManagerCount()
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.EmployeeType == "Manager").ToList();
                return emp.Count;
            }
        }

        public DataTable GetAllEmployees()
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.EmployeeType == "Employee").ToList();
                DataTable dataTable = ConvertToDataTable(emp);
                return dataTable;
            }
        }
        public DataTable GetAllManagers()
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var emp = dbcontext.Employees.Where(x => x.EmployeeType == "Manager").ToList();
                DataTable dataTable = ConvertToDataTable(emp);
                return dataTable;
            }
        }
        public void SetManager(Employee emp)
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var employee = dbcontext.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
                if (employee != null)
                {
                    employee.EmployeeType = emp.EmployeeType;
                    dbcontext.SaveChanges();
                }
            }
        }
        
        
        public List<object> GetEmployeesIds()
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var employees = dbcontext.Employees.Where(x => x.EmployeeType == "Employee").ToList();
                var ids = new List<object>();
                foreach (var emp in employees)
                {
                    ids.Add(emp.Id);
                }
                return ids;
            }
        }
        public List<object> GetManagersIds()
        {
            using (ReportAppDbContext dbcontext = new ReportAppDbContext())
            {
                var managers = dbcontext.Employees.Where(x => x.EmployeeType == "Manager").ToList();
                var ids = new List<object>();
                foreach (var emp in managers)
                {
                    ids.Add(emp.Id);
                }
                return ids;
            }
        }

        public static DataTable ConvertToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Get all the properties by using reflection
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                // Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }

            foreach (var item in items)
            {
                var values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    // Inserting property values to DataTable rows
                    values[i] = properties[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
