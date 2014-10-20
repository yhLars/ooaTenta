using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public class PolisenScraper
    {
        private CrimeHeadlineSystem _crimeHeadlineSystem;
        public string title = string.Empty;

        public PolisenScraper(CrimeHeadlineSystem crimeHeadlineSystem)
        {
            _crimeHeadlineSystem = crimeHeadlineSystem;
            _crimeHeadlineSystem.RegisterPolisenScraper(this);
        }

        public void ReadTopCrime()
        {
            GetPolisenHeadLines();
            _crimeHeadlineSystem.FoundCrime("Polisen", title);
        }

        private void GetPolisenHeadLines()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = @"http://www.polisen.se/";
            HtmlDocument htmlDocument = htmlWeb.Load(url);

            HtmlNode headLine = htmlDocument.DocumentNode.SelectSingleNode(@"//*[@id='newslist-1']/div/ul/li[1]/p[1]/a");

            title = headLine.InnerHtml;
        }
    }
}
