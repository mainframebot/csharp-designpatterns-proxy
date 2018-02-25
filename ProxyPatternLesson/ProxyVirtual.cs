using ProxyPatternLesson.Interfaces;

namespace ProxyPatternLesson
{
    public class ProxyVirtual : ISubject
    {
        private Subject _subject;

        public string Request()
        {
            if(_subject == null)
                _subject = new Subject();

            return "Via Proxy: " + _subject.Request();
        }
    }
}
