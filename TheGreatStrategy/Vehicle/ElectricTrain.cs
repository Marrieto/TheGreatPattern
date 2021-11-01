using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    public class ElectricTrain : Vehicle
    {
        public ElectricTrain()
        {
            this.Engine = new ElectricEngine();
            this.MovementBehaviour = new RailMovement();
        }
    }
}
