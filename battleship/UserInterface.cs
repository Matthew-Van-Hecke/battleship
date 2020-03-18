using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    static class UserInterface
    {
        public static string GetUserInputFor(string type)
        {
            string userInput = Console.ReadLine();
            switch(type)
            {
                case "char":
                    if(validateForChar(userInput))
                    {
                        return userInput;
                    }
                    else
                    {
                        return GetUserInputFor("char");
                    }
                case "int":
                    if(validateForInt(userInput))
                    {
                        return userInput;
                    }
                    else
                    {
                        return GetUserInputFor("int");
                    }
            }
            return userInput;
        }
        public static bool validateForInt(string userInput)
        {
            try
            {
                int userInputAsInt = int.Parse(userInput);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static bool validateForChar(string userInput)
        {
            try
            {
                char userInputAsChar = char.Parse(userInput);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
