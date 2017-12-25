using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Creational.Factory
{
    public interface IEmployee
    {
        float GetSalary();
        float GetBonus();

    }

    public class EmployeeBase
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    public class PartTimeEmployee : EmployeeBase, IEmployee
    {
        public float GetBonus()
        {
            return 60000;
        }
        public float GetSalary()
        {
            return (8 * 100) * 30;
        }
    }

    public class FullTimeEmployee : EmployeeBase, IEmployee
    {
        public float GetBonus()
        {
            return 100000;
        }
        public float GetSalary()
        {
            return 1500 * 30;
        }

    }

    public class EmployeeFactory
    {
        IEmployee employee = null;
        public IEmployee GetEmployeeInstance(EmployeeType type)
        {

            switch (type)
            {
                case EmployeeType.FultTime:
                    employee = new FullTimeEmployee();
                    break;
                case EmployeeType.PartTime:
                    employee = new PartTimeEmployee();
                    break;
                default:
                    break;
            }
            return employee;
        }
    }

    public enum EmployeeType
    {
        FultTime = 1,
        PartTime
    }

}
