using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExp
{
    class RegularExpression
    {
        //Create Array to Store The Data
        string[] lastName = { "Abc", "abc", "bagul", "Bagul", "5Opq", "Xy", "xYz" };
        //Create Pattern
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";

        public void PatternChecking()
        {
            //Used Predefined Regex Class
            Regex regex = new Regex(lastNamePattern);
            foreach (string name in lastName)
            {
                //Used Predefined IsMatch () Method 
                if(regex .IsMatch (name))
                {
                    Console.WriteLine(name + "--> Valid Last Name");
                }
                else
                {
                    Console.WriteLine(name + "--> Invalid Last Name");
                }
            }
        }
    }
}
