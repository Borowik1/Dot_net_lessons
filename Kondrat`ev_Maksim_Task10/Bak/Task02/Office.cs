using System;
using System.Collections.Generic;
using System.Text;

namespace Task02
{
    public delegate void SayHello(Person otherPerson, DateTime time);
    public delegate void SayBye(Person otherName);

    class Office
    {
        private SayHello greetAll;
        private SayBye byeAll;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {
                p.OnCame += OnCameHandler;
                p.OnLeave += OnLeaveHandler;
            }
        }

        private void OnCameHandler(Person p, DateTime time)
        {
            Console.WriteLine($"[{p.Name} пришёл на работу]");
            greetAll?.Invoke(p, time);
            greetAll += p.Greeting;
            byeAll += p.Farewell;
        }

        private void OnLeaveHandler(Person p)
        {
            Console.WriteLine($"[{p.Name} ушёл с работы]");
            greetAll -= p.Greeting;
            byeAll -= p.Farewell;
            byeAll?.Invoke(p);
        }
    }
}
