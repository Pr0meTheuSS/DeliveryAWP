using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    [Serializable]
    class AutoCourier : Courier
    {
        //номер машины
        public string CarNumber;

        //расход топлива (л на 100 км)
        public double FuelConsumption;

        public AutoCourier(string name, int volume, int averagedelivertime, double salaryforpckg, string carnumber, double fuelconsumption) 
            : base(name, volume, averagedelivertime, salaryforpckg) 
        {
            if (carnumber == "" || fuelconsumption < 4)//мин расход топлива у машины в мире 4 л на 100 км
                throw new ArgumentException();

            CarNumber = carnumber;
            FuelConsumption = fuelconsumption;
        }

        public override string GetInfo()
        {
            return Name + " - Авто. Макс посылок: " + Volume + " Ср. время доставки: " + AverageDeliverTime + " минут. Номер машины: " 
                + CarNumber + " Расход топлива на 100км: " + FuelConsumption + " ЗП за 1 посылку: " + SalaryForPckg;
        }
        public override double GetSalary()
        {
            //зп умножается для покрытия расходов на бензин
            return base.GetSalary() * 1.4;
        }

        public override string _GetType()
        {
            return "AutoCourier";
        }


    }
}
