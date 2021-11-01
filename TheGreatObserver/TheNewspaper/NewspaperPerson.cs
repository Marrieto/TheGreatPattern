using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatObserver.TheNewspaper
{
    class NewspaperPerson : IObserver
    {
        public string Name { get; set; }

        public NewspaperPerson(string name)
        {
            Name = name;
        }
        
        public void Update(UpdateObject messageObject)
        {
            Console.WriteLine($"{Name} reads and says, this article {messageObject.Title} from {messageObject.Newspaper} is really good");
        }
    }
}
