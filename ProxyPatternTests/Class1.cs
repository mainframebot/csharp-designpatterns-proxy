using System;
using NUnit.Framework;
using ProxyPatternLesson;

namespace ProxyPatternTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Testing()
        {
            var virtualSubject = new ProxyVirtual();

            var virtualSubjectTest1 = virtualSubject.Request();

            var authSubject = new ProxyAuthentication();

            string authSubjectTest0;


            try
            {
                authSubject.Request();
            }
            catch (Exception ex)
            {
                authSubjectTest0 = ex.Message;
            }

            var authSubjectTest1 = authSubject.Authenticate("password");

            var authSubjectTest2 = authSubject.Request();
        }
    }
}
