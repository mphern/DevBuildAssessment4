using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone
{
    class Program
    {
        static void Main()
        {
            QuadrotorDrone quadDrone = new QuadrotorDrone();

            Console.WriteLine(quadDrone.TotalDistance);
            Console.WriteLine(quadDrone.FlightSpeed(60, 1000));
        }
    }
}
