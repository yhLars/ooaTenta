using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public class UtryckningScraper
    {
        private CrimeHeadlineSystem _crimeHeadlineSystem;
        public string title = string.Empty;

        public UtryckningScraper(CrimeHeadlineSystem crimeHeadlineSystem)
        {
            _crimeHeadlineSystem = crimeHeadlineSystem;
            _crimeHeadlineSystem.RegisterUtryckningScraper(this);
        }

        public void ReadTopCrime()
        {
            GetUtryckningHeadLines();
            _crimeHeadlineSystem.FoundCrime("Utryckning", title);
        }

        private void GetUtryckningHeadLines()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = @"http://orebrotribune.se/utryckning-se/";
            HtmlDocument htmlDocument = htmlWeb.Load(url);

            HtmlNode headLine = htmlDocument.DocumentNode.SelectSingleNode(@"//*[@id='homepage']/div[1]/div[1]/h1/a");

            title = headLine.InnerHtml;
        }

    }
}
