using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace Assignment_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySharedLibrary.DataValidator dataValidator = new MySharedLibrary.DataValidator();
            MySharedLibrary.Logger logger = new MySharedLibrary.Logger();

            UserManagement userManagement = new UserManagement(dataValidator, logger);
            FileProcessing fielprocessing = new FileProcessing(dataValidator, logger);
            DataVisualization dataVisualization = new DataVisualization(dataValidator, logger);


            Console.Write("Enter username for login: ");
            string userInput = Console.ReadLine();
            userManagement.ProcessUserInput(userInput);

            Console.ReadKey();
        }
    }
}
