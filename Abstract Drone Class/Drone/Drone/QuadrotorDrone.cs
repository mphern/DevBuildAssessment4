using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone
{
    class QuadrotorDrone : Drone
    {


        public QuadrotorDrone() : base()
        {
        }

        public QuadrotorDrone(int TotalFlyTime, int TotalDistance) : base(TotalFlyTime, TotalDistance)
        {
        }

        public override double FlightSpeed(int increasedFlightTime, int increasedDistance)
        {
            double calculatedSpeed;
            calculatedSpeed = base.FlightSpeed(TotalFlyTime+increasedFlightTime, TotalDistance+increasedDistance);
            return calculatedSpeed;
        }

        /*The above method utilizes the Liskov Substitution Principal because the FlightSpeed
         * method of the parent is being replaced by the subclasses FlightSpeed method.  It's
         * also utilizing the Single Responsiblity Principal because the Quadrotor classes only
         * responsiblity is to calculate the flight speed of the drone*/

    }
}
