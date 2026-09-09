using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig.oop01
{
    public struct DeliveryAdddress
    {
        public string city;
        public string street;

        public override string ToString()
        {
            return $"{city},{ street}";
        }
    }

    
}
