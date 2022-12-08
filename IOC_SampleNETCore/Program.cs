using Microsoft.Extensions.DependencyInjection;

namespace IOC_SampleNETCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                                    .AddTransient<IConnection, MySqlConnection>()
                                                    .AddSingleton<ICommand, MyCommand>()
                                                    .BuildServiceProvider();

            IConnection connection = serviceProvider.GetService<IConnection>();
            ICommand command = serviceProvider.GetService<ICommand>();
            command.Execute();
            command.Execute("Select * from Customers ");



            Console.ReadLine();
        }
    }

    public interface IConnection
    {
        bool Connection { get; set; }
        string ConnectionString { get; set; }
    }

    public class MySqlConnection : IConnection
    {
        public bool Connection { get; set; }
        public string ConnectionString { get; set; }
    }

    public interface ICommand
    {

        string Command { get; set; }
        void Execute();
        void Execute(string command);
    }

    public class MyCommand : ICommand
    {
        public string Command { get; set; }

        public void Execute()
        {
            Console.WriteLine("Execute Metodu Calisti");
        }

        public void Execute(string command)
        {
            Console.WriteLine(command + " Komutu calisti");
        }
    }
}