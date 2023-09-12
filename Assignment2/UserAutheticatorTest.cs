using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [TestFixture]
    public class UserAuthenticatorTests
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            userAuthenticator.RegisterUser("user1", "Pass1");
            // Assert that the user is registered
            Assert.IsTrue(userAuthenticator.Login("user1", "Pass1"));
        }

        [Test]
        public void TestUserLogin()
        {
            // Register a user first
            userAuthenticator.RegisterUser("user1", "Pass1");

            // Test user login
            Assert.IsTrue(userAuthenticator.Login("user1", "Pass1"));
            Assert.IsFalse(userAuthenticator.Login("sam", "sal"));
            Assert.IsFalse(userAuthenticator.Login("sam", "sal"));
        }

        [Test]
        public void TestPasswordReset()
        {
            // Register a user first
            userAuthenticator.RegisterUser("user1", "Pass1");

            // Reset the password for user
            userAuthenticator.ResetPassword("user1", "user1");

            // Attempt login with the new password
            Assert.IsTrue(userAuthenticator.Login("user1", "user1"));
        }
    }
}