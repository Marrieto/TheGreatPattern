using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatObserver.TheNewspaper
{
    interface IObserver
    {
        public void Update(UpdateObject messageObject);
    }

    public class UpdateObject
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Newspaper { get; set; }
    }
}
