using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    //класс пешего курьера
    [Serializable]
    public class Courier
    {
        public string Name;
        //вместимость 
        public int Volume;

        //среднее время доставки 1 посылки в минутах.
        public int AverageDeliverTime;

        public List<Package> Packages = new List<Package>();
        //время отправки
        public DateTime DateAndTimeOfDispatch;
        //время прибытия обратно
        public DateTime DateAndTimeOfReturns;

        public double SalaryForPckg;

        public int PckgCount = 0;

        public bool IsBusy = false;

        public Courier(string name, int volume, int AverageDeliverTime, double salaryforpckg)
        {
            if (name == "" || volume < 1 || AverageDeliverTime < 1 || salaryforpckg < 100)
                throw new ArgumentException();
            
            Name = name;
            Volume = volume;
            this.AverageDeliverTime = AverageDeliverTime;
            SalaryForPckg = salaryforpckg;
        }

        public bool AddToPackgList(Package package, DateTime startTime)
        {
            if (IsBusy)
                return false;
            if (package == null)
                return false;
            else
            {
                Packages.Add(package);
                if (Packages.Count == Volume)
                    Start(startTime);
                return true;
            }
        } 

        public void Start(DateTime startTime)
        {
            DateAndTimeOfDispatch = startTime;
            DateAndTimeOfReturns = DateAndTimeOfDispatch.AddMinutes(AverageDeliverTime * Packages.Count());
            PckgCount += Packages.Count;
            foreach (Package p in Packages)
            {
                p.Status = EPackageStatus.Done;
            }

            Packages.Clear();
            IsBusy = true;
        }

        public virtual string GetInfo() 
        {
            return Name + " - пеший. Макс посылок: " + Volume + " Ср. время доставки: " + AverageDeliverTime + " минут. ЗП за 1 посылку: " + SalaryForPckg;
        }

        public virtual double GetSalary()
        {
            return PckgCount * SalaryForPckg; 
        }

        public void ResetCounter()
        {
            PckgCount = 0;
        }
    }
}
