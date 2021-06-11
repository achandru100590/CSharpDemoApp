using System;

namespace DemoApp.Patterns.Behaviourial.ChainOfResponsiblity
{
    public interface ILeaveHandler
    {
        void SetNextHandler(ILeaveHandler leaveHandlerler);

        void LeaveApproval(string employeeName, int numberOfDays);
    }

    public class TeamLead : ILeaveHandler
    {
        private ILeaveHandler _leaveHandler;

        public void SetNextHandler(ILeaveHandler leaveHandlerler)
        {
            this._leaveHandler = leaveHandlerler;
        }

        public void LeaveApproval(string employeeName, int numberOfDays)
        {
            if (numberOfDays <= 2)
            {
                Console.WriteLine("Team Lead Approved Your Leaves");
            }
            else
            {
                _leaveHandler.LeaveApproval(employeeName, numberOfDays);
            }
        }
    }

    public class ProjectManager : ILeaveHandler
    {
        private ILeaveHandler _leaveHandler;

        public void SetNextHandler(ILeaveHandler leaveHandlerler)
        {
            this._leaveHandler = leaveHandlerler;
        }

        public void LeaveApproval(string employeeName, int numberOfDays)
        {
            if (numberOfDays <= 20)
            {
                Console.WriteLine("Project Manager Approved Your Leaves");
            }
            else
            {
                _leaveHandler.LeaveApproval(employeeName, numberOfDays);
            }
        }
    }

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