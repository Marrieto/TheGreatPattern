using System;
using System.Collections.Generic;
using TheGreatObserver.TheNewspaper;

namespace TheGreatObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var article1 = new Article() { Author = "Sven Bertil", Title = "Why the common man will succeed", PublishDate = DateTime.UtcNow};
            var article2 = new Article() { Author = "Sven Bertil", Title = "Why Pringles tast bad", PublishDate = DateTime.UtcNow};
            var article3 = new Article() { Author = "Mark Sten", Title = "Wimbledon highlights", PublishDate = DateTime.UtcNow};
            var article4 = new Article() { Author = "Mark Sten", Title = "Wimbledon highlights", PublishDate = DateTime.UtcNow};
            var article5 = new Article() { Author = "Lisa Hall", Title = "Down with the patriarchy and other shenanigans", PublishDate = DateTime.UtcNow};

            var newsPaper1 = new NewspaperSubject("The golden sun");
            var newsPaper2 = new NewspaperSubject("Nimble news");

            var observer1 = new TwitterBot();
            var observer2 = new NewspaperPerson("Josefine Karlsson");
            var observer3 = new AuthorPerson("Martin Lindahl");

            newsPaper1.AddObserver(observer1);
            newsPaper1.AddObserver(observer2);

            newsPaper2.AddObserver(observer1);
            newsPaper2.AddObserver(observer2);
            newsPaper2.AddObserver(observer3);

            var publishList1 = new List<Article> { article1, article2 };
            var publishList2 = new List<Article> { article3, article4, article5 };

            newsPaper1.PublishArticles(publishList1);

            Console.WriteLine("------------------------------------\n");

            newsPaper2.PublishArticles(publishList2);
            
            
            Console.ReadKey();
        }
    }
}
