using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Template
{
    public abstract class CarTemplate
    {
        public void BuildCare()
        {
            Sceleton();
            InstallEngine();
            InstallDoors();
            InstallTiers();
        }

        protected abstract void Sceleton();
        protected abstract void InstallEngine();
        protected abstract void InstallDoors();
        protected abstract void InstallTiers();

    }
}
