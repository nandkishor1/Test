using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

    }
    public class Organization:IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }
        public int Count
        {
            get { return Emps.Count; }
        }
        public Employee this[int index]
        {
            get
            {
                return Emps[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
        public class OrganizationEnumerator : IEnumerator
        {
            Organization OrgColl;
            int CurrentIndex;
            Employee CurrentEmployee;
            public OrganizationEnumerator(Organization org)
            {
                OrgColl = org;
                CurrentIndex = -1;
            }
            public object Current
            {
                get {
                    return CurrentEmployee;
        }
              
               
        }
            public bool MoveNext()
            {
                if (++CurrentIndex >= OrgColl.Count)
                    return false;
                else
                    CurrentEmployee = OrgColl[CurrentIndex];
                return true;
               }
            public void Reset()
            {
               
            }
        }
    }
    class TestEmployee
    {

        static void Main()
        {
            Organization Employees = new Organization();
           // List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee { Id = 101, Name = "Raju", Job = "Manager", Salary = 250000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Vivek", Job = "Salesman", Salary = 20000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Sunil", Job = "Salesman", Salary = 25000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Aayush", Job = "Salesman", Salary = 22000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Nayan", Job = "Developer", Salary = 500000.00 });
            Employees.Add(new Employee { Id = 106, Name = "Nandu", Job = "RiskMangement", Salary = 45000.00 });

            foreach (Employee Emp in Employees)
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            Console.ReadLine();
          
        }

    }
}
