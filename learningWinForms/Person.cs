using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningWinForms
{
    internal class Person
    {
        public string FIO;
        public DateTime birth;
        public int age;

        public Person(string FIO, DateTime birth)
        {
            this.FIO = FIO;
            this.birth = birth;
            this.age = CalculateAge();
        }

        int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birth.Year;

            if (currentDate.Month < birth.Month || (currentDate.Month == birth.Month && currentDate.Day < birth.Day))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"{FIO} - {age} - {birth.ToString("dd:MM:yyyy")} ";
        }
    }
}
