using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.OOPS
{
    public class BaseEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public class FullTimeEmployee : BaseEmployee
    {
        public int Monthly()
        {
            return 500 * 30;
        }
    }
    public class PartTimeEmployee : BaseEmployee
    {
        public int Monthly()
        {
            return (8 * 500) * 30;
        }
    }
}
