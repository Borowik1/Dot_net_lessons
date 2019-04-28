using System;
using System.Collections.Generic;
using System.Text;

namespace Task02
{
    public delegate void OnCame(Person p, DateTime time);
    public delegate void OnLeave(Person p);


    public class Person
    {
        public string Name;
        public event OnCame OnCame;
        public event OnLeave OnLeave;

        public Person(string name)
        {
            Name = name;
        }

        public void GoToWork()
        {
            OnCame?.Invoke(this, DateTime.Now);
        }

        public void GoHome()
        {
            OnLeave?.Invoke(this);
        }

        public void Greeting(Person p, DateTime time)
        {
            if (time.Hour < 12)
            {
                Console.WriteLine($"Доброе утро, {p.Name}! - сказал {Name}.");
            }
            else
            {
                if (time.Hour >= 12 & time.Hour < 17)
                {
                    Console.WriteLine($"Добрый день, {p.Name}! - сказал {Name}.");
                }
                else
                {
                    Console.WriteLine($"Добрый вечер, {p.Name}! - сказал {Name}.");
                }
            }
        }

        public void Farewell(Person p)
        {
            Console.WriteLine($"До свидания, {p.Name}! - сказал {Name}");
        }

    }
}
