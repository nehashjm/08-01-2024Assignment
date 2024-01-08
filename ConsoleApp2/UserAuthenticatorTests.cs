using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [TestFixture]
    public class UserAuthenticatorTests
    {
        [Test]
        public void TestUserRegistration()
        {
            UserAuthenticator authenticator = new UserAuthenticator();
            Assert.IsNotNull(authenticator.RegisterUser("user1", "password1"));
            Assert.IsNotNull(authenticator.RegisterUser("user1", "password2"));
        }
        [Test]
        public void TestUserLogin()
        {
            UserAuthenticator authenticator = new UserAuthenticator();
            authenticator.RegisterUser("user1", "password1");

            Assert.IsTrue(authenticator.LoginUser("user1", "password1"));
            Assert.IsFalse(authenticator.LoginUser("user1", "wrongpassword"));
            Assert.IsFalse(authenticator.LoginUser("nonexistentuser", "password1"));
        }

        [Test]
        public void TestChangePassword()
        {
            UserAuthenticator authenticator = new UserAuthenticator();
            authenticator.RegisterUser("user1", "password1");

            Assert.IsTrue(authenticator.ChangePassword("user1", "newpassword"));
            Assert.IsTrue(authenticator.LoginUser("user1", "newpassword"));
            Assert.IsFalse(authenticator.ChangePassword("nonexistentuser", "newpassword"));
        }
    }
}
