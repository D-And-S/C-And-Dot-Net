using System;

namespace PropteriesDemo
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
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


    }
}
