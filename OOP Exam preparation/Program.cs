using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp = 0;
                while (temp == 0)
                {
                    Console.Write("Which vehicle information do you want :\n[Hints]\n1. Car\n2. MotorCycle\nEnter SL No\t: ");
                    VehicleType vehicleType=(VehicleType)int.Parse(Console.ReadLine());
                    if (vehicleType == (VehicleType)1 || vehicleType == (VehicleType)2)
                    {
                        if (vehicleType == (VehicleType)1)
                        {
                            CarInfo();
                        }
                        else
                        {
                            MototorCycleInfo();
                        }
                        temp = 1;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter correct No :");
                        temp = 0;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
        private static void MototorCycleInfo()
        {
            Console.Write("Model No\t:");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t:");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("No Of Gear\t:");
            int noOfGear = int.Parse(Console.ReadLine());

            Console.Write("Engine Capacity In CC\t:");
            int engineCapacityInCC = int.Parse(Console.ReadLine());

            Console.Write("Max Power\t:");
            int maxPower = int.Parse(Console.ReadLine());

            Console.Write("Max Torque\t:");
            int maxTorque = int.Parse(Console.ReadLine());

            Console.Write("Rear Brake\t:");
            string rearBrake = Console.ReadLine();

            Console.Write("Front Brake\t:");
            string frontBrake = Console.ReadLine();

            Console.Write("Cooling System\t:");
            string coolingSystem = Console.ReadLine();

            Console.Write("Starting Method\t:");
            string startingMethod = Console.ReadLine();

            Console.Write("Millage\t:");
            double millage = double.Parse(Console.ReadLine());

            MotorCycle m = new MotorCycle(maxPower, maxTorque, startingMethod, millage, coolingSystem, frontBrake, rearBrake, modelNo, yearMake, noOfGear, engineCapacityInCC);

            string specification = "";

            while (specification.ToLower() != "0")
            {
                Console.Write("Add Exterior Design[Press 0 to Stop]:");
                specification = Console.ReadLine();
                if (specification.ToLower() != "0")
                {
                    m.AddSpecification(specification);
                }
            }
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine($"Model No\t:{modelNo}");
            Console.WriteLine($"Max Power\t:{maxPower}");
            Console.WriteLine($"Max Torque In BPH\t:{maxTorque}");
            Console.WriteLine($"Starting Method\t:{startingMethod}");
            Console.WriteLine($"Cooling System\t:{coolingSystem}");
            Console.WriteLine($"Front Brake\t:{frontBrake}");
            Console.WriteLine($"Rear Brake\t:{rearBrake}");
            Console.WriteLine($"Millage KMPL\t:{millage}");
            Console.WriteLine($"Year Make\t:{yearMake}");
            Console.WriteLine($"No Of Gear\t:{noOfGear}");
            Console.WriteLine($"Engine Capacity In CC\t:{engineCapacityInCC}");
            Console.WriteLine($"Exterior Design\t:{m.ShowSpecification()}");

        }
        private static void CarInfo()
        {
            Console.Write("Model No\t:");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t:");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("No Of Gear\t:");
            int noOfGear = int.Parse(Console.ReadLine());

            Console.Write("Engine Capacity In CC\t:");
            int engineCapacityInCC = int.Parse(Console.ReadLine());

            Console.Write("No Of Gear\t:");
            int noOfSeat = int.Parse(Console.ReadLine());

            Console.Write("No Of Door\t:");
            int noOfDoor = int.Parse(Console.ReadLine());

            Console.Write("Engine Capacity In CC\t:");
            string stearingSystem = Console.ReadLine();

            Car c = new Car(noOfSeat, noOfDoor, stearingSystem, modelNo, yearMake, noOfGear, engineCapacityInCC);

            string specification = "";

            while (specification.ToLower() != "0")
            {
                Console.Write("Add Interior Design[Press 0 to Stop]:");
                specification = Console.ReadLine();
                if (specification.ToLower() != "0")
                {
                    c.AddSpecification(specification);
                }
            }
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine($"No Of Seat\t:{noOfSeat}");
            Console.WriteLine($"No Of Door\t:{noOfDoor}");
            Console.WriteLine($"Stearing System\t:{stearingSystem}");
            Console.WriteLine($"Model No\t:{modelNo}");
            Console.WriteLine($"Year Make\t:{yearMake}");
            Console.WriteLine($"No Of Gear\t:{noOfGear}");
            Console.WriteLine($"Engine Capacity In CC\t:{engineCapacityInCC}");
            Console.WriteLine($"Interior Design\t:{c.ShowSpecification()}");

        }
    }
}
