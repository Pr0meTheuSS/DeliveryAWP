using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAWP
{
    enum EPackageStatus {         
        Wait,
        Done
    }; 

    class Package
    {         
        string Sender { get; }
        string Reciver { get; }
        DateTime DateAndTimeCreated { get; }
        EPackageStatus Status { get; set; }

        public Package(string sender, string reciver, DateTime dateAndTimeCreated) 
        {
            Sender = sender;
            Reciver = reciver;
            DateAndTimeCreated = dateAndTimeCreated;
            Status = EPackageStatus.Wait;
        }

        public void AssignToDeliveryman(/*DeliveryMan deliveryMan*/)
        {
            Status = EPackageStatus.Done;
            /*deliveryMan.AssignPackage();*/
        }
    }
}
