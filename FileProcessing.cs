using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_25
{
    public class FileProcessing
    {
        private readonly MySharedLibrary.DataValidator datavalidator;
        private readonly MySharedLibrary.Logger logger;

        public FileProcessing(MySharedLibrary.DataValidator dataValidator, MySharedLibrary.Logger logger)
        {
            this.datavalidator = dataValidator;
            this.logger = logger;
        }
        public void ProcessUserInput(string userInput)
        {
            if (datavalidator.ValidateUserData(userInput))
            {
                logger.LogMessage($"User input '{userInput}' is valid.");
            }
            else
            {
                logger.LogMessage($"Invalid user input: '{userInput}'.");
            }
        }

    }
}
