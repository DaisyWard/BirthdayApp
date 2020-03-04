using Microsoft.VisualStudio.TestTools.UnitTesting;
using Birthday;
using System;

namespace BirthdayTests
{
    [TestClass]
    public class BirthdayTests
    {
        [TestMethod]
        public void CheckDateEnteredIsInPast()
        {
            string birthdayDate = new string("12/04/2010");
            bool expected = true;
            DateTime birthdayString = Convert.ToDateTime(birthdayDate);

            // ACT
            bool actual = BirthdayProgram.CheckIfValid(birthdayString);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckDateEnteredIsInFuture()
        {
            string birthdayDate = new string("12/04/2020");
            bool expected = false;
            DateTime birthdayString = Convert.ToDateTime(birthdayDate);

            // ACT
            bool actual = BirthdayProgram.CheckIfValid(birthdayString);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckDateEnteredIsToday()
        {
            string birthdayDate = DateTime.Now.ToString();
            bool expected = true;
            DateTime birthdayString = Convert.ToDateTime(birthdayDate);

            // ACT
            bool actual = BirthdayProgram.CheckIfValid(birthdayString);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }
    }
}
