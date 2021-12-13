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
        int Id { get; }
        string Name { get; }
        string Sender { get; }
        string Reciver { get; }
        DateTime DateAndTimeCreated { get; }
        EPackageStatus Status { get; set; }

        Package(int id, string name, string sender, string reciver, DateTime dateAndTimeCreated) 
        {
            Id = id;
            Name = name;
            Sender = sender;
            Reciver = reciver;
            DateAndTimeCreated = dateAndTimeCreated;
            Status = EPackageStatus.Wait;
        }

        void AssignToDeliveryman(DeliveryMan deliveryMan)
        {
            Status = EPackageStatus.Done;
            deliveryMan.AssignPackage();
        }
    }
}
