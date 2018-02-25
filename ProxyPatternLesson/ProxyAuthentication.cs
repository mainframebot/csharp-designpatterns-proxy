using System;
using ProxyPatternLesson.Interfaces;

namespace ProxyPatternLesson
{
    public class ProxyAuthentication : ISubject
    {
        private Subject _subject;

        private readonly string _password = "password";

        public bool Authenticate(string password)
        {
            if (_password != password)
                return false;

            _subject = new Subject();
            return true;
        }

        public string Request()
        {
            if(_subject == null)
                throw new Exception("Unauthorized!");

            return "Via Proxy: " + _subject.Request();
        }
    }
}
