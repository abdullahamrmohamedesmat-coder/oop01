using System.Globalization;

namespace Assig.oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            //1st answer
            //DeliveryAdddress deliveryAdddress = new DeliveryAdddress() { city = "cairo", street = "abbas" };
            //DeliveryAdddress deliveryAdddress1;

            //deliveryAdddress1 = deliveryAdddress;
            //Console.WriteLine(deliveryAdddress);

            //Console.WriteLine(deliveryAdddress1);
            //Console.WriteLine();


            //deliveryAdddress1.city = "Giza";
            //deliveryAdddress1.street = "alharam";

            //Console.WriteLine(deliveryAdddress);
            //Console.WriteLine(deliveryAdddress1); //struct is vlaue type,Dont't affected
            //Console.WriteLine();

            //Customer customer = new Customer();
            //Customer customer2;
            //customer2 = customer;
            //Console.WriteLine(customer);
            //Console.WriteLine(customer2);
            //Console.WriteLine();

            //customer2.Name = "Ahmed";
            //Console.WriteLine(customer);
            //Console.WriteLine(customer2);//class is Ref Type ,affected 
            #endregion

            #region Question 2
            ////2st answer
            //Shipment shipment = new Shipment();
            //shipment.Description = "test";
            //Console.WriteLine(shipment.Description);


            #endregion

            #region Question 3
            //3st answer
            DeliveryAddress deliveryAdddress = new DeliveryAddress("Cairo", "Abbass", 33);
            DeliveryAddress deliveryAddress01;
            deliveryAddress01 = deliveryAdddress;
            Console.WriteLine(deliveryAdddress.GetAddress());
            Console.WriteLine(deliveryAddress01.GetAddress());
            Console.WriteLine();
            deliveryAddress01.city = "Giza";
            deliveryAddress01.street = "Alharam";
            deliveryAddress01.buildingNumber = 23;
            Console.WriteLine(deliveryAdddress.GetAddress());
            Console.WriteLine(deliveryAddress01.GetAddress());
            Console.WriteLine(); 
            #endregion
        }
    }
}
