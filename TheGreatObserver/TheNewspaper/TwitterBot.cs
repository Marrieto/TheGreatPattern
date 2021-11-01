using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatObserver.TheNewspaper
{
    class TwitterBot : IObserver
    {
        public void Update(UpdateObject messageObject)
        {
            Console.WriteLine($"{messageObject.Newspaper} ----> {messageObject.Title} @{messageObject.Author}");
        }
    }
}
