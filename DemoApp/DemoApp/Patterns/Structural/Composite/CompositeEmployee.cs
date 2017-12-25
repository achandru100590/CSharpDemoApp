using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Composite
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Designation { get; set; }
        string Department { get; set; }
        void AddReportee(List<IEmployee> employees);
        void RemoveReportee(List<IEmployee> employees);
        void Display(int level);
    }
    public class Branch : IEmployee
    {

        private IList<List<IEmployee>> reportees = new List<List<IEmployee>>();
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        public void AddReportee(List<IEmployee> employees)
        {
            reportees.Add(employees);
        }

        public void RemoveReportee(List<IEmployee> employees)
        {
            reportees.Remove(employees); ;
        }


        public void Display(int level)
        {
            string empDisp = new string('-', level) + this.Name + " (" + this.Designation + ") [Dept: " + this.Designation + "]";
            Console.WriteLine(empDisp);

            level += 4;
            foreach (List<IEmployee> empList in reportees)
            {
                foreach (IEmployee emp in empList)
                {
                    emp.Display(level);
                }
            }
        }
    }
    public class Leaf : IEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        public void AddReportee(List<IEmployee> employees)
        {
            throw new NotImplementedException("Invalid Leaf Operation: AddReportee().");
        }

        public void Display(int level)
        {
            string empDisp = new string('-', level) + this.Name + " (" + this.Designation + ") [Dept: " + this.Department + "]";
            Console.WriteLine(empDisp);
        }

        public void RemoveReportee(List<IEmployee> employees)
        {
            throw new NotImplementedException("Invalid Leaf Operation: RemoveReportee().");
        }
    }
}
