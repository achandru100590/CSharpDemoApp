using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Creational.Builder
{
    public interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
    public class MobilePhone
    {
        private string _phoneName;

        public MobilePhone(string phoneName)
        {
            _phoneName = phoneName;
        }

        public string PhoneName { get { return _phoneName; } }

        public ScreenType PhoneScreen { get; set; }

        public Battery PhoneBattery { get; set; }

        public OperatingSystem PhoneOS { get; set; }

        public Stylus PhoneStylus { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
        }
    }
    public class AndroidPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;
        public AndroidPhoneBuilder()
        {
            phone = new MobilePhone("Android Phone");
        }


        public void BuildBattery()
        {
            phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            phone.PhoneOS = OperatingSystem.ANDROID;
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.YES;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        MobilePhone phone;
        public WindowsPhoneBuilder()
        {
            phone = new MobilePhone("Window Phone");
        }

        public void BuildBattery()
        {
            phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            phone.PhoneOS = OperatingSystem.WINDOWS_PHONE;
        }

        public void BuildScreen()
        {
            phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildStylus()
        {
            phone.PhoneStylus = Stylus.NO;
        }

        public MobilePhone Phone
        {
            get { return phone; }
        }
    }  
    public class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
    public enum ScreenType
    {
        ScreenType_TOUCH_CAPACITIVE = 1,
        ScreenType_TOUCH_RESISTIVE,
        ScreenType_NON_TOUCH
    }
    public enum Battery
    {
        MAH_1000 = 1,
        MAH_1500,
        MAH_2000
    }
    public enum OperatingSystem
    {
        ANDROID = 1,
        WINDOWS_MOBILE,
        WINDOWS_PHONE,
        SYMBIAN
    };
    public enum Stylus
    {
        YES,
        NO
    };
}
