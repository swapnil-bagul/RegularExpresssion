using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExp
{
    class RegularExpression
    {
        //Create Array to Store The Data
        //string[] firstNameInput = { "Xyz", "xyz", "Swapnil", "swapnil", "5Opq", "Xy", "xYz" };
        //Create Pattern
        //string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        //string[] lastNameInput = { "Abc", "abc", "bagul", "Bagul", "5Opq", "Xy", "xYz" };
        //string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in","abc.xyz@bl.co.", "abc.xyz@bl.in" };
        string emailPattern = "^[a-z]{3,}[.][a-z]*[@]bl[.]co[.][in]*$";
        public void PatternChecking()
        {
            //Used Predefined Regex Class
            Regex regex = new Regex(emailPattern);
            foreach (string name in emailInputs)
            {
                //Used Predefined IsMatch () Method 
                if(regex .IsMatch (name))
                {
                    Console.WriteLine(name + "--> Valid Email Id");
                }
                else
                {
                    Console.WriteLine(name + "--> Invalid Email Id");
                }
            }
        }
    }
}
