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

        AutoCourier(string name, string carnumber, double fuelconsumption, int volume, int averTime, double salaryforpckg) 
            : base(name, volume, averTime, salaryforpckg) 
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

    }
}
