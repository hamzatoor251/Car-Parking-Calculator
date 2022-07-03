using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Garage
    {
        public Garage()
        {

            Console.Write("Enter Parking Hours: ");
            string hour = Console.ReadLine();
            bool valid = false;
            foreach (char i in hour)
            {
                if (!Char.IsDigit(i) && hour != "q")
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }

            while (hour == "" || valid)
            {
                Console.WriteLine("You entered WRONG entery!!!!!\n");
                Console.Write("Enter Parking Hours Again: ");
                hour = Console.ReadLine();
                foreach (char i in hour)
                {
                    if (!Char.IsDigit(i))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            ParkingHour = Convert.ToInt32(hour);

        }

        protected int ParkingHour { get; set; }

        protected double ExtraFee(double fixFee, double addFee)
        {
            double AddFee = fixFee + (ParkingHour - 3) * addFee;
            return AddFee;
        }
        public void PrintHour()
        {
            Console.WriteLine("Your parking time is " + ParkingHour + "hours");
        }


    }
    class Bike : Garage
    {
        public void ParkingBill()
        {
            Console.WriteLine("Your Bike was at parking.");
            this.PrintHour();


            if (ParkingHour <= 3)
            {
                Console.WriteLine("Your paring bill is: " + "$" + 2);
            }
            else if (ParkingHour > 3 && ParkingHour <= 24 && ExtraFee(2, 0.5) <= 10)
            {
                Console.WriteLine("Your paring bill is: " + "$" + ExtraFee(2, 0.5));
            }
            else if (ExtraFee(2, 0.5) >= 10 && ParkingHour <= 24)
            {
                Console.WriteLine("Your paring bill is: " + "$" + 10);
            }

            else if (ParkingHour > 24)
            {
                Console.WriteLine("You reach your vehicle parking time limit. Your total bill is: " + "$" + 10);
            }
            Console.WriteLine("_______________________________________________");

        }
    }
    class Car : Garage
    {
        public void ParkingBill()
        {
            Console.WriteLine("Your Car was at parking.");
            this.PrintHour();


            if (ParkingHour <= 3)
            {
                Console.WriteLine("Your paring bill is: " + "$" + 4);
            }
            else if (ParkingHour > 3 && ParkingHour <= 24 && ExtraFee(4, 1) <= 20)
            {
                Console.WriteLine("Your paring bill is: " + "$" + ExtraFee(4, 1));
            }
            else if (ParkingHour <= 24 && ExtraFee(4, 1) >= 20)
            {
                Console.WriteLine("Your paring bill is: " + "$" + 20);
            }
            else if (ParkingHour > 24)
            {
                Console.WriteLine("You reach your vehicle parking time limit. Your total bill is: " + "$" + (20));
            }
            Console.WriteLine("_______________________________________________");


        }
    }
    class Bus : Garage
    {
        public void ParkingBill()
        {
            Console.WriteLine("Your Bus was at parking.");
            this.PrintHour();


            if (ParkingHour <= 3)
            {
                Console.WriteLine("Your paring bill is: " + 6);
            }
            else if (ParkingHour > 3 && ParkingHour <= 24 && ExtraFee(6, 1.5) <= 30)
            {

                Console.WriteLine("Your paring bill is: " + ExtraFee(6, 1.5));
            }
            else if (ParkingHour <= 24 && ExtraFee(6, 1.5) >= 30)
            {

                Console.WriteLine("Your paring bill is: " + 30);
            }
            else if (ParkingHour > 24)
            {
                Console.WriteLine("You reach your vehicle parking time limit. Your total bill is: " + (30));
            }
            Console.WriteLine("_______________________________________________");


        }
    }
    class Program
    {
        static void Main()
        {

            Bike bike1 = new Bike();
            bike1.ParkingBill();

            Bike bike2 = new Bike();

            bike2.ParkingBill();
            Bike bike3 = new Bike();

            bike3.ParkingBill();
        }
    }
}
