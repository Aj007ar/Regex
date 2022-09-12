using RegexProblems;

namespace RegexTesting
{
    public class Tests
    {
        ValidateUser validateUser = new ValidateUser();
        [Test]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual = validateUser.ValidateFirstName("Ajay");
            Assert.AreEqual(expected, actual);

        }
        // Test for invalid first name
        [Test]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = validateUser.ValidateFirstName("Aj");
            Assert.AreEqual(expected, actual);

        }
        //Test for last name
        [Test]
        public void TestMethodforLastName()
        {
            try
            {
                validateUser.ValidateLastName("Rathod");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test for invalid last name
        [Test]
        public void TestMethodforInvalidLastName()
        {
            try
            {
                validateUser.ValidateLastName("Ra");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid name";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for empty name
        [Test]
        public void TestMethodforEmptyName()
        {
            try
            {
                validateUser.ValidateLastName("");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Empty name";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //Test for Valid Phonenumber
        [Test]
        public void TestMethodforValidPhoneNumber()
        {
            string actual = validateUser.ValidateMobileNumber("91 7620093382");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //Test for invalid phone number
        [Test]
        public void TestMethodforInvalidPhoneNumber()
        {
            try
            {
                validateUser.ValidateMobileNumber("91 7620093");
            }
            catch (RegexCustomException ex)
            {

                Assert.AreEqual("Invalid PhoneNumber", ex.Message);

            }


        }
        //test for null phone number
        [Test]
        public void TestMethodforNullPhoneNumber()
        {
            try
            {
                validateUser.ValidateMobileNumber(null);
            }
            catch (RegexCustomException ex)
            {
                string expected = "Null";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //test for invalid email
        [Test]
        public void TestInvalidEmail()
        {
            try
            {
                validateUser.ValidateEmailId("abc.@gmail.com");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Email is invalid";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        //Test for valid email
        [Test]
        public void TestEmail()
        {
            string actual = validateUser.ValidateEmailId("abc.@gmail.com");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        //Test for valid password
        [Test]
        public void TestMethodPassword()
        {
            try
            {
                validateUser.ValidatePassRule_1("Ajay1234");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //Test for invalid password
        [Test]
        public void TestMethodInvalidPassword()
        {
            try
            {
                validateUser.ValidatePassRule_1("Ajay1234");
            }
            catch (RegexCustomException ex)
            {
                string expected = "Invalid Password";
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}