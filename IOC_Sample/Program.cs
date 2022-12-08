namespace IOC_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Standart Nesne olusumu
            //Driver driver = new Driver(new BMW());
            //driver.RunCar();
            //driver.RunCar();
            //driver.RunCar(); 
            #endregion


            IUnityContainer container = new UnityContainer();

            #region Standart Kullanim
            //container.RegisterType<ICar, BMW>("BMW");
            //container.RegisterType<ICar, Ford>("Ford");
            //container.RegisterType<ICar, Audi>("Audi");

            //ICar car = container.Resolve<ICar>("Ford");
            //car.Run();



            //Driver driver = container.Resolve<Driver>("Audi");
            //driver.RunCar(); 
            #endregion
            container.RegisterType<ICar, BMW>("BMW");
            container.RegisterType<ICar, Ford>("Ford");
            container.RegisterType<ICar, Audi>("Audi");

            ICar audi = container.Resolve<ICar>("Audi");
            container.RegisterType<Driver>("AuidiDriver", new InjectionConstructor(audi));

            Driver driver = container.Resolve<Driver>("AuidiDriver");
            driver.RunCar();

            #region Register Named Kullanimi



            #endregion
            Console.ReadLine();
        }
    }

    public interface ICar
    {
        int Run();
    }

    public class BMW : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Ford : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }

    }
    public class Driver
    {
        private ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} => {1} mile ", _car.GetType().Name, _car.Run());
        }
    }

}