using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.EmployeeLeave
{
    public class DeliveryManager : ILeaveHandler
    {

        private ILeaveHandler _leaveHandler;
        public void SetNextHandler(ILeaveHandler leaveHandlerler)
        {
            this._leaveHandler = leaveHandlerler;

        }
        public void LeaveApproval(string employeeName, int numberOfDays)
        {
            if (numberOfDays <= 30)
            {
                Console.WriteLine("HR Approved Your Leaves");
            }
            else
            {
                _leaveHandler.LeaveApproval(employeeName, numberOfDays);
            }
        }
    }
}
