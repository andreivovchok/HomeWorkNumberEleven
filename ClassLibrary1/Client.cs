using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Client
    {
        private void OnWeatherPublished()
        {
            Console.WriteLine("Weather");
        }

        private void OnNewsPublished()
        {
            Console.WriteLine("News");
        }

        private void OnSportPublished()
        {
            Console.WriteLine("Sport");
        }

        private void OnIncidentPublished()
        {
            Console.WriteLine("Incident");
        }

        private void OnHumorPublished()
        {
            Console.WriteLine("Humor");
        }

        public void SubscribeOnNews(NewsCategory newsCategory, NewsProvider newsProvider)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    newsProvider.NewsPublished += OnNewsPublished;
                    break;
                case NewsCategory.Weather:
                    newsProvider.WeatherPublished += OnWeatherPublished;
                    break;
                case NewsCategory.Sport:
                    newsProvider.SportPublished += OnSportPublished;
                    break;
                case NewsCategory.Incident:
                    newsProvider.IncidentPublished += OnIncidentPublished;
                    break;
                case NewsCategory.Humor:
                    newsProvider.HumorPublished += OnHumorPublished;
                    break;
            }
        }

        public void OnSubscribeOnNews(NewsCategory newsCategory, NewsProvider newsProvider)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    newsProvider.NewsPublished -= OnNewsPublished;
                    break;
                case NewsCategory.Weather:
                    newsProvider.WeatherPublished -= OnWeatherPublished;
                    break;
                case NewsCategory.Sport:
                    newsProvider.SportPublished -= OnSportPublished;
                    break;
                case NewsCategory.Incident:
                    newsProvider.IncidentPublished -= OnIncidentPublished;
                    break;
                case NewsCategory.Humor:
                    newsProvider.HumorPublished -= OnHumorPublished;
                    break;
            }
        }
    }
}
