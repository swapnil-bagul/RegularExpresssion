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
        //string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in","abc.xyz@bl.co.", "abc.xyz@bl.in" };
        //string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
        string[] mobileNumberInput = { "91 7410177019", "01 3634345678", "917410177019", "91 741017701", "91 0123344556", "91 7410177016", "912 7410177019", "76 7410177019" };
        string mobileNumberPattern = "^[91]{2}[ ]{1}[6-9]{1}[0-9]{9}$";

        public void PatternChecking()
        {
            //Used Predefined Regex Class
            Regex regex = new Regex(mobileNumberPattern);
            foreach (string number in mobileNumberInput)
            {
                //Used Predefined IsMatch () Method 
                if(regex .IsMatch (number))
                {
                    Console.WriteLine(number + "--> Valid Mobile Number");
                }
                else
                {
                    Console.WriteLine(number + "--> Invalid Mobile Number");
                }
            }
        }
    }
}
