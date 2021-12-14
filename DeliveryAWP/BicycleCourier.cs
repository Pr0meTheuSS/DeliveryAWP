using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    class BicycleCourier : Courier
    {
        //модель и номер велосипеда
        public string Bicycle;
        BicycleCourier(string name, int volume, int averTime, double salaryforpckg, string bicycle) 
            : base(name, volume, averTime, salaryforpckg)
        {
            if (bicycle == "")
                throw new ArgumentException();

            Bicycle = bicycle;
        }

        public override string GetInfo()
        {
            return Name + " - вело. Макс посылок: " + Volume + " Ср. время доставки: " + AverageDeliverTime + " минут. ЗП за 1 посылку: " + SalaryForPckg + " Велосипед: " + Bicycle;
        }

        public override double GetSalary()
        {
            //умножается, чтобы поощрить эффективность велосипеда.
            return base.GetSalary() * 1.2;
        }
    }
}
