using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmpService : IEmpService
    {
        public string AddEmployee(EmployeeType value)
        {

            Employee entity = new Employee()
            {

                 emp_no = value.Id,
                 dept_no = value.DeptNo,
                 emp_fname = value.FirstName,
                 emp_lname= value.LastName
            };

            using (var db = new empModelEntities())
            {
                var empl = db.Employees.FirstOrDefault(e => e.emp_no == value.Id);

                if (empl == null)
                {

                    db.Employees.Add(entity);
                    db.SaveChanges();

                    return value.Id + " -> User Created";

                }
                
            }

            return value.Id + " -> User already exists";
        }

        public List<EmployeeType> RetreiveEmployees()
        {

            var empList = new List<EmployeeType>();

            using (var db = new empModelEntities())
            {

                empList = db.Employees.
                    Select(e => new EmployeeType
                    {
                         DeptNo = e.dept_no,
                         FirstName = e.emp_fname,
                         LastName = e.emp_lname,
                         Id= e.emp_no
                    })
                    .ToList();
            }

            return empList;




        }

        public EmployeeType RetreiveEmployeeByID(int id)
        {
            EmployeeType empl = new EmployeeType();

            using (var db = new empModelEntities())
            {

                empl = db.Employees.Where(e => e.emp_no == id).
                    Select(e => new EmployeeType
                    {
                        DeptNo = e.dept_no,
                        FirstName = e.emp_fname,
                        LastName = e.emp_lname,
                        Id = e.emp_no
                    })
                    .FirstOrDefault();
            }

            return empl;
        }

        public string UpdateEmployee(EmployeeType value, int id)
        {
            using (var db = new empModelEntities())
            {

                Employee entity = new Employee()
                {

                    emp_no = value.Id,
                    dept_no = value.DeptNo,
                    emp_fname = value.FirstName,
                    emp_lname = value.LastName
                };

                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

            return value.Id  + " -> User Updated";
        }


        public string DeleteEmployee(int id)
        {
           
            using (var db = new empModelEntities())
            {

                var empl = db.Employees.FirstOrDefault(e => e.emp_no == id);


                if (empl != null)
                {
                    db.Employees.Remove(empl);
                    db.SaveChanges();

                    return id + " -> User deleted";
                }

            }
            
            return id +  " ->  User not available";
        }

    }
}
