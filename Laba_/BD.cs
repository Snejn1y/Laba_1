using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba_
{
    class BD
    {
        int d, m, y;

        DateTime dateTime = DateTime.Now;

        public BD(int d, int m, int y)
        {
            int days = DateTime.DaysInMonth(y, m);
            if (d > days)
                MessageBox.Show("Day > possible days");
            if (m > 12)
                MessageBox.Show("Months > possible months");
            if (y > this.dateTime.Year)
                MessageBox.Show("Years > nowaday");

            this.d = d;
            this.m = m;
            this.y = y;
        }

        private void nowdate()
        {

            this.d = this.dateTime.Day;
            this.m = this.dateTime.Month;
            this.y = this.dateTime.Year;
        }
        public BD()
        {
            nowdate();
        }

        public int Age()
        {
            return this.dateTime.Year - this.y;
        }

        private DateTime DateBirth(int d, int m, int y)
        {
            DateTime bddate = DateTime.Parse(this.d.ToString("d") + '.' + this.m.ToString() + '.' + this.y.ToString());
            return bddate;
        }

        public int Days()
        {

            return (this.dateTime - DateBirth(this.d, this.m, this.y)).Days;
        }

        public int Mounths()
        {
            DateTime now = this.dateTime;
            DateTime birthDate = DateBirth(this.d, this.m, this.y);
            int months = (now.Year - birthDate.Year) * 12 + now.Month - birthDate.Month;
            if (now.Day < birthDate.Day)
            {
                months--;
            }
            return months;
        }

        public string FullAge()
        {
            DateTime birthDate = DateBirth(this.d, this.m, this.y);
            int years = this.dateTime.Year - birthDate.Year;
            int months = this.dateTime.Month - birthDate.Month;
            int days = this.dateTime.Day - birthDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(this.dateTime.Year, this.dateTime.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            return $"{years} років {months} місяців {days} днів";
        }

        public int days_print()
        {
            return this.d;
        }

        public int months_print()
        {
            return this.m;
        }

        public int years_print() 
        { 
            return this.y;
        }
    }
}
