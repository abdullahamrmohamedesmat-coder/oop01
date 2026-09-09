using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig.oop01
{
    public class Shipment
    {
        private string description; //three problems :1)public fields is allowed to anyone to modifiey them directly
                                     //2)Don't control fields ,invaild fields
        private double weight;            //3)No flexibilty

        private decimal deliveryFee;

        public string Description {
            get {

                return description;            
            
                }
            set
            {
                Description = value;
            }
                
                
          }
       public double Weight
        {
            get
            {
                return Weight;

            }
            set
            {

                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {

                return deliveryFee;
            }
            set { deliveryFee = value; }
        }

    }
}
