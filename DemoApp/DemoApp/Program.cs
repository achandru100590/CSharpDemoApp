using DemoApp.Concepts.Delegates;
using DemoApp.OOPS;
using DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Aunthentication;
using DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Authentication;
using DemoApp.Patterns.Behaviourial.Command;
using DemoApp.Patterns.Behaviourial.Strategy;
using DemoApp.Patterns.Behaviourial.Template.House;
using DemoApp.Patterns.Creational.Builder;
using DemoApp.Patterns.Creational.Factory;
using DemoApp.Patterns.Creational.Singleton;
using DemoApp.Patterns.Decorator;
using DemoApp.Patterns.Structural.Composite;
using DemoApp.Patterns.Structural.Facade;
using DemoApp.Patterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using CompositeIEmployee = DemoApp.Patterns.Structural.Composite.IEmployee;
using CORLeave = DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.EmployeeLeave;
using CORLog = DemoApp.Patterns.Behaviourial.ChainOfResponsiblity.Logger;
using FactoryIEmployee = DemoApp.Patterns.Creational.Factory.IEmployee;
using Memento = DemoApp.Patterns.Behaviourial.Memento;
using SN = DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork;
using Template = DemoApp.Patterns.Behaviourial.Template;
using YTC = DemoApp.Patterns.Behaviourial.Observer.YoutubeChannel;

namespace DemoApp
{
    class Program
    {
        static string url = "https://ramj2ee.blogspot.in/2013/12/all-design-patterns-links.html#.Wj-y4N-WbIU";


        static void Main(string[] args)
        {


            BaseClass d2 = new DerivedClass();
            d2.Print();

            BaseClass1 d22 = new DerivedClass1();
            d22.Print(); 

            Console.ReadKey();
        }

        #region Sorting Algorithms

        /// <summary>
        /// 1. Repeatedly steps through the array elements 
        /// 2. Compare adjacent elements and swap if they are in wrong order         
        /// </summary>
        private static void BubbleSort()
        {
            //https://www.youtube.com/watch?v=o4bAoo_gFBU

            int[] numbers = new[] { 1, 3, 2, 4, 5 };
            int lenght = numbers.Length;
            int tempNumber = 0;
            bool hasSwapping = true;

            // "hasSwapping" if there is no Swapping which means array sorted already, so no need looping and break the pass
            for (int i = 0; (i < lenght) && hasSwapping; i++)
            {
                Debug.WriteLine(i);

                hasSwapping = false;

                for (int j = 0; j < lenght - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                        hasSwapping = true;
                    }
                }
            }

            PrintArray(numbers);

        }

        /// <summary>
        /// 1. Find minimum value from the array and swap the Min value with starting index of the unsorted array
        /// 2. Repeate the process for unsorted array
        /// </summary>
        private static void SelectionSort()
        {

            //https://www.youtube.com/watch?v=9oWd4VJOwr0&list=PLdo5W4Nhv31bEiyP4tclZMc5mP_X7OD7k&index=3

            int[] numbers = new[] { 1, 3, 2, 3, 2, 3, 1, 6, 8, 5, 7 };
            int minValueIndex = 0;
            int minValue = 0;
            int temp = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                minValue = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (minValue > numbers[j])
                    {
                        minValue = numbers[j];
                        minValueIndex = j;
                    }
                }
                if (minValue != numbers[i])
                {
                    temp = numbers[i];
                    numbers[i] = minValue;
                    numbers[minValueIndex] = temp;
                }
            }


            PrintArray(numbers);
        }

        /// <summary>
        /// 1. consider first index of array as sorted array and rest all are unsorted
        /// 2. take first element from the unsorted array and find the proper place in sorted array and insert the element into sorted array
        /// 3. repeate the process till end of unsorted array
        /// </summary>
        private static void InsertionSort()
        {

            //https://www.youtube.com/watch?v=yCxV0kBpA6M&list=PLdo5W4Nhv31bEiyP4tclZMc5mP_X7OD7k&index=2

            int[] numbers = new[] { 4, 3, 1, 2, 5 };
            int temp = 0;
            int j = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                temp = numbers[i];
                j = i - 1;

                while (j >= 0 && numbers[j] > temp)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = temp;

            }

            PrintArray(numbers);

        }
        private static void MergeSort() { }
        private static void QuickSort() { }
        private static void HeapSort() { }
        private static void CountingSort() { }
        private static void RadixSort() { }

        private static int GetMinValueOfArray()
        {
            int[] arr = new[] { 2, 4, 1, 3, 5 };

            int minValue = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }

        private static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }

        private static int FirstDuplicate(int[] a)
        {
            int temp = -1;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (temp == -1)
                        {
                            temp = j - i;
                        }
                        else
                        {
                            if (temp > (j - i))
                            {
                                temp = i;
                            }
                            temp = j - i;
                        }
                    }
                }
            }

            if (temp == -1)
            {
                return -1;
            }

            return a[temp];
        }

        private static int FirstDuplicate2(int[] a)
        {
            int temp = -1;
            int counter = 0;
            int first = -1;
            int second = -1;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        counter++;

                        if (temp == -1)
                        {
                            temp = i;
                            first = i;
                            second = j;
                        }
                        else
                        {
                            if (counter == 2)
                            {
                                if (a[i] != a[temp])
                                {

                                    if (i < j && second > j)
                                    {
                                        return a[i];
                                    }
                                    return a[temp];
                                }
                                counter--;
                            }
                        }
                        break;
                    }

                    if (counter == 2)
                    {
                        break;
                    }
                }
            }

            if (temp == -1)
            {
                return -1;
            }

            return a[temp];
        }

        #endregion
        private static void FindPrimeNumFromNValue()
        {
            Console.WriteLine("Enter Number To Get Prime");

            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    if (j > i)
                    {
                        break;
                    }
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static void FindPrimeFromList()
        {
            Console.WriteLine("Please enter list of number by comma(,) value to filter only prime from it");

            var list = Console.ReadLine().Split(',');

            int[] numbers = new int[list.Length];

            bool isPrime = true;

            for (int i = 0; i < list.Length; i++)
            {
                numbers[i] = Convert.ToInt32(list[i]);
            }

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                if (number != 0 && number != 1)
                {
                    for (int j = 2; j < numbers[numbers.Length - 1]; j++)
                    {
                        if (j > number)
                        {
                            break;
                        }

                        if (number != j && number % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(number);
                    }

                    isPrime = true;
                }
            }
        }

        private static char FirstNotRepeatingCharacter(string s)
        {


            char[] letters = s.ToCharArray();
            int length = letters.Length;


            for (int i = 0; i < length; i++)
            {
                bool isRepeated = false;
                for (int j = i; j < length; j++)
                {
                    if (i != j && letters[i] == letters[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }

                if (!isRepeated) return letters[i];
            }

            return '_';

        }


        #region Delegates

        private static void FindNumber()
        {

            int[] numbers = new[] { 8, 3, 6, 7, 9, 2, 4 };

            Numbers number = new Numbers();

            //var greaterThanFive = number.GetNumberGreaterThanFive(numbers);
            //var lessThanSeven = number.GetNumberLessThanSeven(numbers);
            //var LessThanFive = number.GetNumberLessThanFive(numbers);

            var greaterThanFive = number.GetNumbers(numbers, x => x > 5);

            Console.WriteLine(" ---------Using Deletgate -----------");

            foreach (var num in greaterThanFive)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine(" ---------Using Predicate -----------");

            var lessThanFive = number.GetNumbers(numbers, LessThanFive);

            foreach (var num in lessThanFive)
            {
                Console.WriteLine(num);
            }



        }
        private static bool LessThanFive(int num)
        {
            return num < 5;
        }

        private static void DeleageEmployee()
        {
            List<Concepts.Delegates.Employee> lstEmployess = new List<Concepts.Delegates.Employee>
            {
                new Concepts.Delegates.Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Experience = 5, Salary = 10000 },
                new Concepts.Delegates.Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Experience = 10, Salary = 20000 },
                new Concepts.Delegates.Employee() { ID = 103, Name = "Anurag", Experience = 15, Salary = 30000 }
            };


            Concepts.Delegates.Employee employee = new Concepts.Delegates.Employee();

            Console.WriteLine("----------- Employee Promoted By Salary -------------");
            employee.PromoteEmployee(lstEmployess, PromoteEmployeeBySalary);

            Console.WriteLine("----------- Employee Promoted By Experience -------------");
            employee.PromoteEmployee(lstEmployess, PromoteEmployeeByExperience);


        }
        private static bool PromoteEmployeeBySalary(Concepts.Delegates.Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool PromoteEmployeeByExperience(Concepts.Delegates.Employee employee)
        {
            if (employee.Experience > 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private static void MultiCasting()
        {
            Publisher publisher = new Publisher();

            SendViaEmail SE = new SendViaEmail();
            SendViaMobile SM = new SendViaMobile();

            publisher.publishmsg += SE.sendEmail;
            publisher.publishmsg += SM.sendMessage;


            publisher.PublishMessage("Hello You Have received New Notification");

        }

        private static void VideoEncoderDelegate()
        {
            VideoEncode videoEncode = new VideoEncode();

            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            Video video = new Video() { Title = "Demo Video" };

            videoEncode.VideoEncoder += mailService.VedionEncoded;
            videoEncode.VideoEncoder += messageService.VedionEncoded;

            videoEncode.Encode(video);
        }

        private static void YouTubePublisherDelegate()
        {
            var Bala = new YouTubePublisher()
            {
                UserName = "Bala",
                Password = "afdfa"
            };
            var Bala1 = new YouTubePublisher()
            {
                UserName = "Bala1",
                Password = "afdfa"
            };

            var Ji = new Subscriber()
            {
                UserName = "Ji",
                Password = "afdfdf"
            };
            var Ram = new Subscriber()
            {
                UserName = "Ram",
                Password = "afdfdf"
            };

            Ram.Subscribe(Bala);
            Ram.Subscribe(Bala1);
            Ji.Subscribe(Bala);
            Bala.UploadVideo("SampleVideo.mp4");
            Bala1.UploadVideo("SV.mp4");
        }


        #endregion



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
            BankBase sbi = new SBI();
            BankBase iob = new IOB();
            BankBase hdfc = new HDFC();

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

        #region Behaviourial

        private static void TemplatePattern()
        {
            Template.CarTemplate audi = new Template.Audi();
            Template.CarTemplate bmw = new Template.BMW();
            Template.CarTemplate benz = new Template.Benz();

            audi.BuildCare();
            bmw.BuildCare();
            benz.BuildCare();


            HouseTemplate woodenHouse = new WoodenHouse();
            woodenHouse.BuildHouse();

            HouseTemplate glassHouse = new GlassHouse();
            glassHouse.BuildHouse();


        }

        private static void ChainOfResponsibilityPattern()
        {
            #region Leave Aprroval
            CORLeave.ILeaveHandler teamLead = new CORLeave.TeamLead();
            CORLeave.ILeaveHandler projectManager = new CORLeave.ProjectManager();
            CORLeave.ILeaveHandler hr = new CORLeave.DeliveryManager();

            teamLead.SetNextHandler(projectManager);
            projectManager.SetNextHandler(hr);

            teamLead.LeaveApproval("Chandra", 8);
            #endregion

            #region Logger

            CORLog.LoggerHandler info = new CORLog.Info();
            CORLog.LoggerHandler debug = new CORLog.Debug();
            CORLog.LoggerHandler error = new CORLog.Error();

            info.SetNextLoggerHandler(debug);
            debug.SetNextLoggerHandler(error);

            info.Log("Error");

            #endregion

            #region Aunthentication

            AuthenticationHandler singleFA = new SingleFactorAuthentication();
            AuthenticationHandler secondFA = new SecondFactorAuthentication();
            AuthenticationHandler multiFA = new MultiFactorAuthentication();

            singleFA.SetAuthenticationHandler(secondFA);
            secondFA.SetAuthenticationHandler(multiFA);

            singleFA.Authendicate(AuthenticationType.OTP);

            #endregion

        }

        private static void IteratorPattern()
        {
            SN.ISocialNetwork faceBook = new SN.FaceBook();
            SN.IIterator faceBookIterator = faceBook.CreateIterator();
            Iterate(faceBookIterator);

            SN.ISocialNetwork twitter = new SN.Twitter();
            SN.IIterator twitterIterator = twitter.CreateIterator();
            Iterate(twitterIterator);
        }

        private static void Iterate(SN.IIterator iterator)
        {
            while (!iterator.isDone())
            {
                Console.WriteLine(string.Format("User Name : {0}", iterator.CurrentItem()));
                iterator.Next();
            }

        }

        private static void ObservablePattern()
        {
            YTC.ISubscriber subscriber1 = new YTC.User() { Name = "Ram" };
            YTC.ISubscriber subscriber2 = new YTC.User() { Name = "Anbu" };
            YTC.ISubscriber subscriber3 = new YTC.User() { Name = "Bala" };

            YTC.IPublisher channel = new YTC.YouTubeChannel();
            channel.Subscribe(subscriber1);
            channel.Subscribe(subscriber2);
            channel.Subscribe(subscriber3);

            Console.WriteLine("Three user are subscribed \n");

            channel.NotifyToSubscribers(); // New Update to channel

            Console.WriteLine("\n One user is unsubscribed \n");

            channel.UnSubscrie(subscriber1);

            channel.NotifyToSubscribers(); // New Update to channel
        }

        private static void MementoPattern()
        {
            Memento.CareTaker carTaker = new Memento.CareTaker();
            Memento.Orginator orginator = new Memento.Orginator();

            orginator.SetMessage("TestMessage1");
            carTaker.AddMemento(orginator.SaveMessage());

            orginator.SetMessage("TestMessage2");
            carTaker.AddMemento(orginator.SaveMessage());

            orginator.SetMessage("TestMessage3");
            carTaker.AddMemento(orginator.SaveMessage());

            orginator.SetMessage("TestMessage3");
            carTaker.AddMemento(orginator.SaveMessage());

            orginator.RestoreMessage(carTaker.Undo());
            orginator.RestoreMessage(carTaker.Undo());
            orginator.RestoreMessage(carTaker.Redo());

            Console.WriteLine(orginator.GetMessage());
        }

        private static void CommandPattern()
        {

            WordDocument document = new WordDocument();
            ICommand openCommand = new Open(document);
            ICommand saveCommand = new Save(document);
            ICommand closeCommand = new Close(document);

            openCommand.Execute();
            saveCommand.Execute();
            closeCommand.Execute();
        }

        private static void StrategyPattern()
        {

            var today = DateTime.Today.DayOfWeek;

            IOfferStrategy offerStrategy;


            if ((today == DayOfWeek.Saturday) || (today == DayOfWeek.Sunday))
            {
                offerStrategy = new WeekendOffer();
            }
            else
            {
                offerStrategy = new WeekDaysOffer();
            }

            offerStrategy.Offer();
        }

        #endregion

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
            string checkPaymentReciept = checkProxy.PayFund(10000);
            Console.WriteLine(" Reciept Number : {0}", checkPaymentReciept);

            IPayment onlinePaymentProxy = new OnlinePaymentProxy("ICICI", 10002222, DateTime.Now);
            string onlinePaymentReciept = onlinePaymentProxy.PayFund(50000);
            Console.WriteLine(" Reciept Number : {0}", onlinePaymentReciept);
        }

        private static void ProxyProtection()
        {
            url = "https://ramj2ee.blogspot.in/2013/11/proxy-design-pattern-implementation.html#.Wj_bNN-WbIU";
            IFolder folderProxy1 = new FolderProxy(new User { Name = "Chandra", Password = "1234", Designation = Designation.CEO });
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
