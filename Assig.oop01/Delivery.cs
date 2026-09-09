using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig.oop01
{
    internal struct DeliveryAddress
    {
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }
        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            city = City;
            street = Street;
            buildingNumber = BuildingNumber;
        }


        public string GetAddress()
        {
            return $"{buildingNumber}, {city}, {street}";
        }
    }
}
