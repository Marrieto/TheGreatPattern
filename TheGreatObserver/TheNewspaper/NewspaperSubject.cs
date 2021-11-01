using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatObserver.TheNewspaper
{
    class NewspaperSubject : ISubject
    {
        public string Name { get; set; }
        public List<IObserver> Observers { get; set; }
        public List<Article> ArticlesToPublish { get; set; }

        public NewspaperSubject(string name)
        {
            Name = name;
            Observers = new List<IObserver>();
            ArticlesToPublish = new List<Article>();
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var article in ArticlesToPublish)
            {
                foreach (var observer in Observers)
                {
                    observer.Update(new UpdateObject() 
                    { 
                        Title = article.Title,
                        Author = article.Author,
                        Newspaper = Name
                    });
                }
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void PublishArticles(List<Article> articles)
        {
            Console.WriteLine($"The newspaper {Name} is beginning to publish article/s");

            foreach (var article in articles)
            {
                ArticlesToPublish.Add(article);
            }

            NotifyObservers();
        }
    }
}
