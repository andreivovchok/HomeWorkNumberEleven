using System;
using ClassLibrary1;

namespace HomeWorkNumberEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();

            Client client = new Client();

            client.SubscribeOnNews(NewsCategory.Humor, newsProvider);
            newsProvider.PublishNews(NewsCategory.Humor);

            client.SubscribeOnNews(NewsCategory.Incident, newsProvider);
            newsProvider.PublishNews(NewsCategory.Incident);

            client.SubscribeOnNews(NewsCategory.Sport, newsProvider);
            newsProvider.PublishNews(NewsCategory.Sport);

            client.OnSubscribeOnNews(NewsCategory.Sport, newsProvider);
            newsProvider.PublishNews(NewsCategory.Sport);
        }
    }
}
