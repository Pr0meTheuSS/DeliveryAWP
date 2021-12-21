using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    public class BicycleCourier : Courier
    {
        //модель и номер велосипеда
        public string Bicycle;
        public BicycleCourier(string name, int volume, int averagedelivertime, double salaryforpckg, string bicycle) 
            : base(name, volume, averagedelivertime, salaryforpckg)
        {
            if (bicycle == "")
                throw new ArgumentException();

            Bicycle = bicycle;
        }

        public override string GetInfo()
        {
            return Name + " - вело. Макс посылок: " + Volume + " Ср. время доставки: " + AverageDeliverTime + 
                " минут. ЗП за 1 посылку: " + SalaryForPckg + " Велосипед: " + Bicycle;
        }

        public override double GetSalary()
        {
            //умножается, чтобы поощрить эффективность велосипеда.
            return base.GetSalary() * 1.2;
        }
        public override string _GetType()
        {
            return "BicycleCourier";
        }

    }
}
