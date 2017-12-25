using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Proxy
{
    public interface IFolder
    {
        void ReadWriteAccess();
    }

    public class FolderProxy : IFolder
    {
        User user = new User();
        Folder folder = new Folder();

        public FolderProxy(User user)
        {
            this.user = user;
        }

        public void ReadWriteAccess()
        {
            switch (user.Designation)
            {
                case Designation.CEO:
                case Designation.Director:
                case Designation.Manager:
                    folder.ReadWriteAccess();
                    break;
                case Designation.Lead:
                case Designation.Associate:
                    Console.WriteLine("\nYou have no folder access.");
                    break;
                default:
                    Console.WriteLine("\nYou have no folder access.");
                    break;

            }
        }
       
    }

    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public Designation Designation { get; set; }
    }

    public enum Designation
    {
        CEO = 1,
        Director,
        Manager,
        Lead,
        Associate
    }

    public class Folder : IFolder
    {
        public void ReadWriteAccess()
        {
            Console.WriteLine("\nYou can read and write folder now.");
        }
    }
}
