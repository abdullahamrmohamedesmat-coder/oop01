using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assig.oop01
{
    internal struct DeliveryCenter
    {
        private Shipment[] arr;
        private int size;
        public DeliveryCenter(int Size)
        {

            Shipment[] arr = new Shipment[size];
            size = Size;
        }

        public Shipment this[int index]
        {
            get
            {
                if(index > 0 || index < size )
                    return arr[index];
                return default( Shipment); 
            }
            set
            {
                if(index > 0 || index < size )
                    arr[index] = value;
                Console.WriteLine("do nothing"); 
                 
            }
        }
        public string this[int index,string trackingCode]
        {
            get
            { 
                if (index > 0 || index < size )
                  return arr[index].TrackingCode;
                return default( string );
            }
        }

        public bool AddShipment( Shipment shipment)
        {
            shipment.Trackingcode = Console.ReadLine();
            shipment.Description = Console.ReadLine();
            shipment.Weight=Convert.ToDecimal?(Console.ReadLine());
            shipment.DeliVeryFee = Convert.ToDecimal(Console.ReadLine());


        }
    }
}
