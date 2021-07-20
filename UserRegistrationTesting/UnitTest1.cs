using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistration userRegistration;
        UserRegistrationAnnotation user;
        [TestInitialize]
        public void TestSetup()
        {
            userRegistration = new UserRegistration.UserRegistration();
            user = new UserRegistrationAnnotation();
        }
        [TestCategory("NameTest")]
        [TestMethod]
        public void TestFirstName1()
        {
            //Assign
            string expected = "1";
            string name = "Siva";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFirstName2()
        {
            //Assign
            string expected = "0";
            string name = "siva10";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestFirstNameException()
        {
            //Assign
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                //act
                string actual = userRegistration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestMethod]
        public void TestLastName1()
        {
            //Assign
            string expected = "1";
            string name = "Ranjani";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName2()
        {
            //Assign
            string expected = "1";
            string name = "Ranjani10";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastNameException()
        {
            //Assign
            string expected = "Name should not be null";
            string name = null;
            try
            {
                //act
                string actual = userRegistration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestCategory("Email")]
        [TestMethod]
        public void EmailTest1()
        {
            //Assign
            string expected = "1";
            string emailId = "www3@gmail.com";
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailTest2()
        {
            //Assign
            string expected = "0";
            string emailId = "www-3@gmail.com";
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailExceptionTest()
        {
            //Assign
            string expected = "Email should not be null";
            string emailId = null;
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Moblie number validation")]
        [TestMethod]
        public void MobileTest1()
        {
            //Assign
            string expected = "1";
            string mobileNo = "91 8667361462";
            //act
            string actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MobileTest2()
        {
            //Assign
            string expected = "0";
            string mobileNo = "918667361462";
            //act
            string actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest1()
        {
            //Assign
            string expected = "1";
            string password = "Sivabalaan10";
            //act
            string actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest2()
        {
            //Assign
            string expected = "0";
            string password = "Siv@balaan10";
            //act
            string actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            //Assign
            string expected = "Password should not be empty";
            string password = "";
            //act
            try
            {
                string actual = userRegistration.CheckPassword(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ce)
            {
                //assert
                Assert.AreEqual(ce.Message, expected);
            }
        }
        /// <summary>
        /// Checks for validation using annotation
        /// </summary>
        [TestMethod]
        public void CheckForValidation()
        {
            user.firstName = "Siva";
            user.lastName = "Ranjani";
            user.phoneNumber = "9908735627";
            user.EmailAddress = "www@gmail.com";
            user.Password = "Sivabalan10";
            string expected = "Satisfied all the validation";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if name is not valid 
        /// </summary>
        [TestMethod]
        public void CheckForValidation1()
        {
            user.firstName = "siv";
            user.lastName = "Ranjani";
            user.phoneNumber = "8667361462";
            user.EmailAddress = "www-3@gmail.com";
            user.Password = "Siv@balan0";
            string expected = "First Name should be min of 3";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if phone number not valid
        /// </summary>
        [TestMethod]
        public void CheckForValidation2()
        {
            user.firstName = "Siva";
            user.lastName = "Ranjani";
            user.phoneNumber = "8667361462";
            user.EmailAddress = "ww@gmail.com";
            user.Password = "Sivabalaan10;
            string expected = "Phone number should exactly 10";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }


    }
}
