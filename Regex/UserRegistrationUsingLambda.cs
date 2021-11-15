using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExp
{
    public class UserRegistrationUsingLambda
    {
        //declare instance variable
        string message;

        //Create Constructor
        public UserRegistrationUsingLambda (string message)
        {
            this.message = message;
        }

        //Create Method For Validating
        public string ValidateFristName()
        {
            //Crete Pattern
            string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            //bool type variable
            bool result = testMethod(message);
            //Create Method and Used Expression Lambda Function
            bool testMethod(string firstName) => (Regex.IsMatch(firstName, firstNamePattern));
            
            //Programming Construct
            if (result)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }
        //Create Method For Validating
        public string ValidateLastName()
        {
            //Crete Pattern
            string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
            //bool type variable
            bool result = testMethod(message);
            //Create Method and Used Expression Lambda Function
            bool testMethod(string lastName) => (Regex.IsMatch(lastName, lastNamePattern));

            //Programming Construct
            if (result)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }
        //Create Method For Validating
        public string ValidateEmail()
        {
            //Crete Pattern
            string emailPattern = "^[A-Z]{1}[a-z]{3,}@gmail.com$";
            //bool type variable
            bool result = testMethod(message);
            //Create Method and Used Expression Lambda Function
            bool testMethod(string email) => (Regex.IsMatch(email, emailPattern));

            //Programming Construct
            if (result)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }
        //Create Method For Validating
        public string ValidateMobileNumber()
        {
            //Crete Pattern
            string mobilePattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
            //bool type variable
            bool result = testMethod(message);
            //Create Method and Used Expression Lambda Function
            bool testMethod(string mobileNum) => (Regex.IsMatch(mobileNum, mobilePattern));

            //Programming Construct
            if (result)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }
        //Create Method For Validating
        public string ValidatePassword()
        {
            //Crete Pattern
            string passwordPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}";
            //bool type variable
            bool result = testMethod(message);
            //Create Method and Used Expression Lambda Function
            bool testMethod(string passkey) => (Regex.IsMatch(passkey, passwordPattern));

            //Programming Construct
            if (result)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }

        }


    }
}
