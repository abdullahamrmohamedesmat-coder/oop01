using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig.oop01
{
    internal struct Shipment
    {
        private string trackingcode;
        private string descriptionattribute;
        private double weight;
        private decimal deliveryFee;

        public Shipment(string TrackingCode)
        {
           
        }
        public  Shipment(string TrackingCode,string Description,double Weight,decimal DeliveryFee,DeliveryAdddress Destinatioin)
        {
            trackingcode = TrackingCode;
            descriptionattribute = "unknown";
            deliveryFee = 50;
        }

        public string Destination(DeliveryAddress deliveryAddress)
        {
            return deliveryAddress.GetAddress();
        }
        public string Trackingcode
        {
            get
            {
                return trackingcode;
            }
            set
            {
                if (trackingcode != null)
                    trackingcode = value;

            }
        }
        public string DescriptionAttribute
        {

            get
            {
                return descriptionattribute;

            }
            set
            {
                if (descriptionattribute != null)
                {
                    descriptionattribute = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;

            }
            set
            {
                if (weight > 0)
                {
                    weight = value;
                }

            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            set
            {
                if (deliveryFee > 0) {
                    deliveryFee = value;
                }
            }

        }
        public string TrackingCode
        {
            get
            {
                return trackingcode;
            }
        }
        public string Description
        {
            get
            {
                return descriptionattribute;
            }
            set
            {

                if (descriptionattribute != null)
                {
                    descriptionattribute = value;

                }
            }
        }
        public double Weight02
        {
            get
            {
                return weight;
            }
            set
            {
                if (weight > 0)
                    weight = value;
            }
        }


        public decimal DeliVeryFeep { get; private set; }
        public string Destination02{ get; set; } 

        public object EstimatedCost
        {
            get
            {
                return deliveryFee + (decimal)(weight * 5);
            }
        }
        public decimal UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
               return deliveryFee += newFee;
            }
            return -1;
        }
        public override string ToString()
        {
            return $"{trackingcode},{descriptionattribute},{weight},{deliveryFee}";
        }
        public void PrintShipment()
        {
            Console.WriteLine(trackingcode);
            Console.WriteLine(descriptionattribute);
            Console.WriteLine(deliveryFee);
            Console.WriteLine(weight);
            Console.WriteLine(Destination);
            Console.WriteLine(EstimatedCost);
        }
    }
}
