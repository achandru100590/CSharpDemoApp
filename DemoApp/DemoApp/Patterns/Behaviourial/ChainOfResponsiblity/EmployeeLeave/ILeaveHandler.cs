using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.EmployeeLeave
{
    public interface ILeaveHandler
    {
        void SetNextHandler(ILeaveHandler leaveHandlerler);        
        void LeaveApproval(string employeeName, int numberOfDays);
    }
}
