using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatDecorator
{
    public interface IPizza
    {
        public string GetDescription();

        public double GetCost();
    }
}
