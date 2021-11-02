using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExp
{
    class RegularExpression
    {
        //Create Array to Store The Data
        string[] input = { "Xyz", "xyz", "Swapnil", "swapnil","5Opq", "Xy", "xYz" };
        //Create Pattern
        string pattern = "^[A-Z]{1}[a-z]{2,}$";

        public void PatternChecking()
        {
            //Used Predefined Regex Class
            Regex regex = new Regex(pattern );
            foreach (string name in input )
            {
                //Used Predefined IsMatch () Method 
                if(regex .IsMatch (name))
                {
                    Console.WriteLine(name + "--> Valid Name");
                }
                else
                {
                    Console.WriteLine(name + "--> Invalid Name");
                }
            }
        }
    }
}
