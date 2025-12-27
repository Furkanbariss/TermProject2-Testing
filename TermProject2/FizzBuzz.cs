using System;
using System.Collections.Generic;
using System.Text;

namespace TermProject2
{
    //internal class FizzBuzz
    //{
    //}

    public class FizzBuzz
    {
        public string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
