using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public abstract class ScraperBase : IScreenScraperService
    {
        public abstract string ScrapeUrl { get; }
        public abstract string xPath { get; }

        public string GetHeadLine()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = string.Format(this.ScrapeUrl);
            HtmlDocument htmlDocument = htmlWeb.Load(url);

            HtmlNode headLine = htmlDocument.DocumentNode.SelectSingleNode(this.xPath);

            return headLine.InnerHtml;
        }

        public abstract string ReadTopCrime();
    }
}
