using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        private string name;         //Имя
        private string lastName;     //Фамилия
        private string middleName;   //Отчество

        Exception ex = new Exception();


        public User(string lastName, string name, string middleName)
        {
            this.LastName = lastName;
            this.Name = name;
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Возвравщает "true" если слово состоит из кириллицы и начинается с заглавной буквы
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        protected bool StringCheck(string str)
        {
            Regex reg = new Regex(@"^[А-ЯЁ][а-яё]*$");
            if (!reg.IsMatch(str))
            {
                Console.Write("Неверный формат данных");
                throw ex;
            }
            else
            {
                return true;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (StringCheck(value))
                {
                    lastName = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (StringCheck(value))
                {
                    name = value;
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (StringCheck(value))
                {
                    middleName = value;
                }
            }
        }
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                return GetDiffOfDates(this.DateOfBirth);
            }
        }
        /// <summary>
        /// Вычисляет разницу в годах от введённой до текущей даты
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        protected int GetDiffOfDates(DateTime date)
        {
            int diff;
            DateTime now = new DateTime();
            now = DateTime.Now;
            diff = now.Year - date.Year;
            if (now.Month < date.Month | (now.Month == date.Month & now.Day < date.Day))
            {
                diff--;
            }

            if (diff < 0)
            {
                throw new Exception("ОШИБКА!Отрицательный возраст");
            }
            return diff;
        }
    }

}
