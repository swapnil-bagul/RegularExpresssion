﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExp
{
    class RegularExpression
    {
        //UC1
        //Create Array to Store The Data
        //string[] firstNameInput = { "Xyz", "xyz", "Swapnil", "swapnil", "5Opq", "Xy", "xYz" };
        //Create Pattern
        //string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";

        //UC2
        //string[] lastNameInput = { "Abc", "abc", "bagul", "Bagul", "5Opq", "Xy", "xYz" };
        //string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";

        //UC3       
        //string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in","abc.xyz@bl.co.", "abc.xyz@bl.in" };
        //string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";

        //UC4
        //string[] mobileNumberInput = { "91 7410177019", "01 3634345678", "917410177019", "91 741017701", "91 0123344556", "91 7410177016", "912 7410177019", "76 7410177019" };
        //string mobileNumberPattern = "^[91]{2}[ ]{1}[6-9]{1}[0-9]{9}$";

        //UC5
        //string[] passwordInput = { "qwertyui","asdfghjkl","asdebnd","vbnnmkmP","poiuh","zxcvbnmlk", "qwertyuP" };
        //string passwordPattern = "^[a-z]{8}$";

        //UC6
        /// <summary>
        /// (?=.*[A-Z]) At least on Capital Exist
        /// </summary>
        //string[] passwordInput = { "qWertyui", "asdmTThl", "asdexbnd", "vbnnmkmP", "poiuh", "zxcvbnmlk", "qwertyuP" };
        //string passwordPattern = "^(?=.*[A-Z])[a-zA-Z]{8}$";

        //UC7
        /// <summary>
        /// (?=.*[0-9]) At least one number is exist
        /// </summary>
        //string[] passwordInput = { "qWe90yui", "as6mTThl", "asdexbnd", "vbn9mkmP", "poiuh", "zxcvbnmlk", "6wPrtyuP" };
        //string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8}$";

        //UC8
        //(?=.*\W) At least one non Word Exist
        string[] passwordInput = { "qWe90yui", "as6mTThl", "asdexbnd", "vbn9mkmP", "poiuh", "zxcvbnmlk", "6wPrtyuP" };
        //string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*\W)[a-zA-Z0-9@#$%&*?]{8}$";

        //(?=.*\W) At least one non Word Exist

        // Pattern validating
        //public void PatternChecking()
        //{
        //    //Used Predefined Regex Class
        //    Regex regex = new Regex(passwordPattern);
        //    foreach (string number in passwordInput)
        //    {
        //        //Used Predefined IsMatch () Method 
        //        if(regex .IsMatch (number))
        //        {
        //            Console.WriteLine(number + "--> Valid Password");
        //        }
        //        else
        //        {
        //            Console.WriteLine(number + "--> Invalid Password");
        //        }
        //    }
        //}
    }
}
