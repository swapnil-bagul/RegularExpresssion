using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExp;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Test Method For First Name
        public void FirstNameTest()
        {
            //Arrange
            string input = "Swapnil";
            string expected = "Valid";

            //Act
            UserRegistrationUsingLambda userRegistrationUsingLambda = new UserRegistrationUsingLambda(input);
            string actual=userRegistrationUsingLambda.ValidateFristName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //Test Method For Last
        [TestMethod]
        public void LastNameTest()
        {
            //Arrange
            string input = "Bagul";
            string expected = "Valid";

            //Act
            UserRegistrationUsingLambda userRegistrationUsingLambda = new UserRegistrationUsingLambda(input);
            string actual = userRegistrationUsingLambda.ValidateLastName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Test Method For Email Name
        [TestMethod]
        public void EmailTest()
        {
            //Arrange
            string input = "Swapnilbagul@gmail.com";
            string expected = "Valid";

            //Act
            UserRegistrationUsingLambda userRegistrationUsingLambda = new UserRegistrationUsingLambda(input);
            string actual = userRegistrationUsingLambda.ValidateEmail();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Test Method For Mobile Number
        [TestMethod]
        public void MobileNumberTest()
        {
            //Arrange
            string input = "91 7410177019";
            string expected = "Valid";

            //Act
            UserRegistrationUsingLambda userRegistrationUsingLambda = new UserRegistrationUsingLambda(input);
            string actual = userRegistrationUsingLambda.ValidateMobileNumber();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Test Method For PassWord
        [TestMethod]
        public void PassWordTest()
        {
            //Arrange
            string input = "Swap@123";
            string expected = "Valid";

            //Act
            UserRegistrationUsingLambda userRegistrationUsingLambda = new UserRegistrationUsingLambda(input);
            string actual = userRegistrationUsingLambda.ValidatePassword();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
