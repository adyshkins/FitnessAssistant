using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant.Tests
{
    [TestClass]
    public class UserSearchTests
    {        
        //[TestMethod]
        public void GetUser_log1andpassw1_falsereturn()
        {
            // // arrange
            string txtLogin = "OP";
            string txtPassword = "OP";
            bool ex = true;

            // // act
            bool result = FitnessAssistant.HelperClass.UserSearch.GetUser(txtLogin, txtPassword);
            
            // // assert

            Assert.AreEqual(ex, result);
        }
    }
}
