using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public class FizzBuzz
    {
        public string FizzBuzzChallenge(int number)
        {
            var answer = "";
           if (number % 3 == 0)
            {
                answer = "fizz";
            }
            if (number % 5 == 0) 
            {
                answer += "buzz";
            }
            
            return answer;
        }
    }
}
