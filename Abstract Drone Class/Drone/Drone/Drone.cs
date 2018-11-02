using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone
{
    abstract class Drone
    {
        private int totalFlyTime;
        private int totalDistance;

        public Drone()
        {
            totalFlyTime = 60;
            totalDistance = 5000;
        }
        public Drone(int TotalFlyTime, int TotalDistance)
        {
            totalFlyTime = TotalFlyTime;
            totalDistance = TotalDistance;
        }

        public int TotalFlyTime { get { return totalFlyTime; } set { totalFlyTime = value; } }  
        public int TotalDistance { get { return totalDistance; } set { totalDistance = value; } }


        public virtual double FlightSpeed(int totalFlyTime, int totalDistance)
        {
            double calculatedSpeed;
            calculatedSpeed = (double)totalDistance / totalFlyTime;
            return calculatedSpeed;
        }

    }
}
