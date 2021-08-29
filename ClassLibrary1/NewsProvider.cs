using System;

namespace ClassLibrary1
{
    public class NewsProvider
    {
        public event Action NewsPublished = delegate { };
        public event Action WeatherPublished = delegate { };
        public event Action SportPublished = delegate { };
        public event Action IncidentPublished = delegate { };
        public event Action HumorPublished = delegate { };

        public void PublishNews(NewsCategory newsCategory)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    NewsPublished();
                    break;
                case NewsCategory.Weather:
                    WeatherPublished();
                    break;
                case NewsCategory.Sport:
                    SportPublished();
                    break;
                case NewsCategory.Incident:
                    IncidentPublished();
                    break;
                case NewsCategory.Humor:
                    HumorPublished();
                    break;
            }
        }
    }
}
