using DemoApp.OOPS;
using DemoApp.Patterns.Creational.Builder;
using DemoApp.Patterns.Structural.Facade;
using FactoryIEmployee = DemoApp.Patterns.Creational.Factory.IEmployee;
using DemoApp.Patterns.Creational.Singleton;
using CompositeIEmployee = DemoApp.Patterns.Structural.Composite.IEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Patterns.Structural.Composite;
using DemoApp.Patterns.Structural.Proxy;
using DemoApp.Patterns.Decorator;
using DemoApp.Patterns.Creational.Factory;

namespace DemoApp
{
    class Program
    {
        static string url = "https://ramj2ee.blogspot.in/2013/12/all-design-patterns-links.html#.Wj-y4N-WbIU";


        static void Main(string[] args)
        {
            DecoratorPizza();

            Console.ReadKey();
        }

        #region OOPS Concepts

        private static void Car()
        {
            Honda honda = new Honda();

            Console.WriteLine("-----------Honda Details -------------");
            Console.WriteLine("Wheel : {0}", honda.Wheel());
            Console.WriteLine("AC    : {0}", honda.AC());
            Console.WriteLine("Price : {0}", honda.Price());


            Maruthi maruthi = new Maruthi();

            Console.WriteLine("-----------Maruthi Details -------------");
            Console.WriteLine("Wheel : {0}", maruthi.Wheel());
            Console.WriteLine("AC    : {0}", maruthi.AC());
            Console.WriteLine("Price : {0}", maruthi.Price());


            Audi audi = new Audi();

            Console.WriteLine("-----------Audi Details -------------");
            Console.WriteLine("Wheel : {0}", audi.Wheel());
            Console.WriteLine("AC    : {0}", audi.AC());
            Console.WriteLine("GPS    : {0}", audi.GPS());
            Console.WriteLine("Price : {0}", audi.Price());
        }

        private static void Bank()
        {
            SBI sbi = new SBI();
            IOB iob = new IOB();
            HDFC hdfc = new HDFC();

            Console.WriteLine("SBI interest is {0} ", sbi.Interest());
            Console.WriteLine("IOB interest is {0} ", iob.Interest());
            Console.WriteLine("HDFC interest is {0} ", hdfc.Interest());
        }

        private static void Employee()
        {
            OOPS.FullTimeEmployee ftm = new OOPS.FullTimeEmployee();
            ftm.ID = 111;
            ftm.Name = "Ashok";
            ftm.Department = "QA";


            Console.WriteLine("----------- FullTimeEmplyee Details---------");
            Console.WriteLine("ID         : {0}", ftm.ID);
            Console.WriteLine("Name       : {0}", ftm.Name);
            Console.WriteLine("Department : {0}", ftm.Department);
            Console.WriteLine("Salary     : {0}", ftm.Monthly());

            OOPS.PartTimeEmployee ptm = new OOPS.PartTimeEmployee();
            ptm.ID = 222;
            ptm.Name = "Chandru";
            ptm.Department = "Dev";


            Console.WriteLine("----------- PartTimeEmployee Details---------");
            Console.WriteLine("ID         : {0}", ptm.ID);
            Console.WriteLine("Name       : {0}", ptm.Name);
            Console.WriteLine("Department : {0}", ptm.Department);
            Console.WriteLine("Salary     : {0}", ptm.Monthly());
        }

        private static void AbtractionEncapsulation()
        {
            BeverageMaker beverageMaker = new BeverageMaker();
            beverageMaker.Make(new Tea());
            beverageMaker.Make(new Coffee());
        }

        #endregion

        #region Desing Patterns

        #region Creational
        private static void SingletonPattern()
        {
            Parallel.Invoke(() =>
            {
                Singleton logfromEmployee = Singleton.GetInstance;
                logfromEmployee.ErrorLog("Error 404");
            },
            () =>
            {
                Singleton logfromDepartment = Singleton.GetInstance;
                logfromDepartment.ErrorLog("Error 400");
            });

            Parallel.Invoke(() =>
            {
                ST.ErrorLog("Error 404");
            },
           () =>
           {

               ST.ErrorLog("Error 400");
           });
        }

        private static void FacadePatternCar()
        {
            Model model = new Model("Honda");
            Engine engine = new Engine("BIV");
            Body body = new Body("IND");
            Accessories accessories = new Accessories("Jappan");

            CarFacade car = new CarFacade(model, engine, body, accessories);
            car.MakeCar();
        }

        private static void FacadePatternPizza()
        {
            Dough dough = new Dough();
            Sauce sauce = new Sauce("Tomatto");
            Topping topping = new Topping("Green Pepper");
            Cheese cheese = new Cheese("white");
            Oven oven = new Oven(5);

            PizzaFacade pizza = new PizzaFacade(dough, sauce, topping, cheese, oven);
            pizza.MakePizza();
        }

        private static void FactoryPatternEmployee()
        {
            EmployeeFactory employeeFactory = new EmployeeFactory();
            FactoryIEmployee employee = employeeFactory.GetEmployeeInstance(EmployeeType.PartTime);

            EmployeeBase emp = (EmployeeBase)employee;
            emp.FirstName = "Chandra";
            emp.LastName = "Sekaran";

            Console.WriteLine("Bonus : {0}", employee.GetBonus());
            Console.WriteLine("Salary : {0}", employee.GetSalary());
            Console.WriteLine("Full Name : {0}", emp.GetFullName());
        }

        private static void FactoryPatternAnimal()
        {
            LandAnimalFactory landAnimalFactory = new LandAnimalFactory();

            IAnimal animal = landAnimalFactory.GetAnimal(Animal.Cat);

            Console.WriteLine("I am {0} and Speak {1}.", Animal.Cat, animal.Speak());
        }

        private static void AbstractFactoryPatternAnimal()
        {
            AnimalType enumAnimalType = AnimalType.Sea;
            Animal enumAnimal = Animal.Shark;

            AnimalFactory animalfactory = AnimalFactory.GetAnimalFactory(enumAnimalType);
            IAnimal animal = animalfactory.GetAnimal(enumAnimal);

            Console.WriteLine("I am {0}, I will speak {1} and I live on {2}", enumAnimal, animal.Speak(), enumAnimalType);
        }

        private static void BuilderPattern()
        {
            Manufacturer manufacturer = new Manufacturer();

            IPhoneBuilder phoneBuilder = null;

            phoneBuilder = new AndroidPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());

            phoneBuilder = new WindowsPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());
        }

        #endregion

        #region Structural

        private static void Composite()
        {
            url = "https://ramj2ee.blogspot.in/2013/10/composite-design-pattern-introduction.html#.Wj-yR9-WbIU";
            url = "http://www.dotnettricks.com/learn/designpatterns/composite-design-pattern-dotnet";

            CompositeIEmployee director = new Branch { Name = "Vinayak", Designation = "Director of Depart", Department = "Director" };
            CompositeIEmployee lead1 = new Branch { Name = "Chandra", Designation = "Dev Team Lead", Department = "Dev" };
            CompositeIEmployee lead2 = new Branch { Name = "Sekar", Designation = "Testing Team Lead", Department = "QA" };
            CompositeIEmployee manager1 = new Branch { Name = "Ravi", Designation = "Dev Manager", Department = "Dev" };
            CompositeIEmployee manager2 = new Branch { Name = "Dinesh", Designation = "QA Manager", Department = "QA" };
            CompositeIEmployee developer1 = new Leaf { Name = "Guna", Designation = "QA Manager", Department = "Dev" };
            CompositeIEmployee developer2 = new Leaf { Name = "Raj", Designation = "QA Manager", Department = "Dev" };
            CompositeIEmployee developer3 = new Leaf { Name = "Kavi", Designation = "QA Manager", Department = "QA" };
            CompositeIEmployee developer4 = new Leaf { Name = "Arul", Designation = "QA Manager", Department = "QA" };

            lead1.AddReportee(new List<CompositeIEmployee> { developer1, developer2 });
            lead2.AddReportee(new List<CompositeIEmployee> { developer3, developer4 });
            manager1.AddReportee(new List<CompositeIEmployee> { lead1 });
            manager2.AddReportee(new List<CompositeIEmployee> { lead2 });
            director.AddReportee(new List<CompositeIEmployee> { manager1, manager2 });

            director.Display(1);
        }

        private static void ProxyPayment()
        {
            IPayment checkProxy = new CheckProxy("HDFC", 10002000, DateTime.Now);
            string checkPaymentReciept =  checkProxy.PayFund(10000);
            Console.WriteLine(" Reciept Number : {0}", checkPaymentReciept);

            IPayment onlinePaymentProxy = new OnlinePaymentProxy("ICICI", 10002222, DateTime.Now);
            string onlinePaymentReciept = onlinePaymentProxy.PayFund(50000);
            Console.WriteLine(" Reciept Number : {0}", onlinePaymentReciept);
        }

        private static void ProxyProtection()
        {
            url = "https://ramj2ee.blogspot.in/2013/11/proxy-design-pattern-implementation.html#.Wj_bNN-WbIU";
            IFolder folderProxy1= new FolderProxy(new User { Name = "Chandra", Password = "1234", Designation = Designation.CEO });
            folderProxy1.ReadWriteAccess();

            IFolder folderProxy2 = new FolderProxy(new User { Name = "Guna", Password = "65478", Designation = Designation.Associate });
            folderProxy2.ReadWriteAccess();

        }

        private static void ProxyVirtual()
        {
            IImage imageProxy = new ImageProxy("Flower");
            imageProxy.DisplayImage();
            imageProxy.DisplayImage();
        }

        private static void DecoratorPizza()
        {
            IPizza orderedPizza = new Pizza("Dominos Margaretta Large (VEG)");
            orderedPizza = new ExtraSoya(orderedPizza);
            orderedPizza = new ExtraCheese(orderedPizza);

            Console.WriteLine(orderedPizza.Description());
            Console.WriteLine("Total Cost = " + orderedPizza.Cost);


        }

        private static void DecoratorDosa()
        {
            IDosa plainDosa = new PlainDosa();
            //Console.WriteLine("Description : {0} - Price {1}", plainDosa.GetDescription(), plainDosa.GetPrice());

            Ghee ghee = new Ghee(plainDosa);

            Onion onion = new Onion(ghee);
            Console.WriteLine("Description : {0} - Total Price : Rs. {1}", onion.GetDescription(), onion.GetPrice());

            Powder powder = new Powder(onion);
            Console.WriteLine("Description : {0} - Total Price : Rs. {1}", powder.GetDescription(), powder.GetPrice());

        }

        #endregion

        #endregion
    }
}
