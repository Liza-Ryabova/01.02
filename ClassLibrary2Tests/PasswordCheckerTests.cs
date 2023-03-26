using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbol_ReturnsTrue()
        {
            //Arrange.
            string password = "ASqw12$$";
            bool expected = true;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbol_ReturnsFalse()
        {
            //Arrange.
            string password = "Aq1$";

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_30Symbol_ReturnsFalse()
        {
            //Arrange.
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            //Arrange.
            string password = "ASDqwe1$";
            bool expected = true;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            //Arrange.
            string password = "ASDqweASD$";
            bool expected = false;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            //Arrange.
            string password = "Aqwe123$";
            bool expected = true;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            //Arrange.
            string password = "Aqwe123";
            bool expected = false;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            //Arrange.
            string password = "Aqwe123$";
            bool expected = true;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            //Arrange.
            string password = "asdqwe123$";
            bool expected = false;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            //Arrange.
            string password = "ASDq123$";
            bool expected = true;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            //Arrange.
            string password = "ASDQWE123$";
            bool expected = false;
            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}