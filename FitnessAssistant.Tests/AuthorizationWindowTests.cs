using System;
using FitnessAssistant.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant.Tests
{
    [TestClass]
    public class AuthorizationWindowTests
    {
        [TestMethod]
        public void GetUser_log1andpassw1_falsereturn()
        {
            // arrange
            string txtLogin = "log1";
            string txtPassword = "pasw1";
            bool result = false;

            // act
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
           // bool ex = authorizationWindow.GetUser(txtLogin, txtPassword);
            // assert
            Assert.AreEqual(ex, result);
        }
    }
}
