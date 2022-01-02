using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class Helper
    {
        public static string AskFizzBuzz(int number)
        {
            string result = null;

            result = AskFizz(number);
            if (result == number.ToString())
            {
                result = AskBuzz(number);
            }
            else
            {
                if (AskBuzz(number) == "buzz")
                {
                    result += AskBuzz(number);
                }
            }

            return result;
        }
        public static string AskFizz(int number)
        {
            string result = number.ToString();

            if (number % 3 == 0)
            {
                result = "fizz";
            }

            return result;
        }

        public static string AskBuzz(int number)
        {
            string result = number.ToString();

            if (number % 5 == 0)
            {
                result = "buzz";
            }

            return result;
        }
    }
}
