using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    public enum EPackageStatus 
    {         
        Wait,
        InWork,
        Done
    }; 

    [Serializable]
    public class Package
    {
        public string Sender;
        public string Reciver;
        public DateTime DateAndTimeCreated;
        public EPackageStatus Status;
        public Courier Deliver; 
        public void SetStatus(EPackageStatus status)
        {
            Status = status;
        }

        public Package(string sender, string reciver, DateTime dateAndTimeCreated) 
        {

            if (sender == "" || reciver == "" || dateAndTimeCreated == null)
                throw new ArgumentException();

            Sender = sender;
            Reciver = reciver;
            DateAndTimeCreated = dateAndTimeCreated;
            Status = EPackageStatus.Wait;
            Deliver = null;
        }

        public void AssignToDeliver(Courier courier) {
            Deliver = courier;
        }

    }
}
