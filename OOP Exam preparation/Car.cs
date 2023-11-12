using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_preparation
{
    public sealed class Car:FourWheeler
    {
        public Car()
        {
            
        }
        public Car(int noOfSeat, int noOfDoor, string stearingSystem, string modelNo, int yearMake,
            int noOfGear, int engineCapacityInCC)
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            NoOfGear = noOfGear;
            EngineCapacityInCC = engineCapacityInCC;
            NoOfSeat = noOfSeat;
            NoOfDoor = noOfDoor;
            StearingSystem = stearingSystem;
        }

        public int NoOfSeat { get; set; }
        public int NoOfDoor { get; set; }
        public string StearingSystem { get; set; }
    }
}
