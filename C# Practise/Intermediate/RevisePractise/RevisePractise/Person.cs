using System;

namespace RevisePractise
{
    public class Person
    {
        public string Name;
        //private DateTime _birthdate;
        public DateTime Birthdate { get; private set; }
        public int month { get; set; }

        public int MonthNumber
        {
            get => month;
            set
            {
                if((value > 0) && (value < 13))
                {
                    month = value;
                }else
                {
                    month = 0;
                }
              
            }
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }


        //public void setBirthDate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime getBirthdate()
        //{
        //    return _birthdate;
        //}

        //public DateTime Birthdate
        //{
        //    set { _birthdate = value; }
        //    get { return _birthdate; }
        //}

        public Person()
        {

        }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public void Introduce(string to)
        {
            Console.WriteLine("HI {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }


    }
}
