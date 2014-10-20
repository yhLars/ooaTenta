using System.Net;
using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public class PolisenScraper : ScraperBase
    {
        private CrimeHeadlineSystem _crimeHeadlineSystem;
        public string Title = string.Empty;

        public PolisenScraper(CrimeHeadlineSystem crimeHeadlineSystem)
        {
            _crimeHeadlineSystem = crimeHeadlineSystem;
            _crimeHeadlineSystem.RegisterPolisenScraper(this);
        }

        public override string ScrapeUrl
        {
            get { return "http://www.polisen.se/"; }
        }

        public override string xPath
        {
            get { return @"//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }

        public override string ReadTopCrime()
        {
            return _crimeHeadlineSystem.FoundCrime("Polisen", GetHeadLine());
        }
    }
}
