using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatStrategy
{
    public class DieselTrain : Vehicle
    {
        public DieselTrain()
        {
            this.Engine = new InternalCombustionEngineDiesel();
            this.MovementBehaviour = new RailMovement();
        }
    }
}
