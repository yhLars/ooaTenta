using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public class PolisenScraper
    {
        private CrimeHeadlineSystem _crimeHeadlineSystem;
        public string Title = string.Empty;
        private const string Url = @"http://www.polisen.se/";

        public PolisenScraper(CrimeHeadlineSystem crimeHeadlineSystem)
        {
            _crimeHeadlineSystem = crimeHeadlineSystem;
            _crimeHeadlineSystem.RegisterPolisenScraper(this);
        }

        public void ReadTopCrime()
        {
            GetPolisenHeadLines();
            _crimeHeadlineSystem.FoundCrime("Polisen", Title);
        }

        private void GetPolisenHeadLines()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(Url);

            HtmlNode headLine = htmlDocument.DocumentNode.SelectSingleNode(@"//*[@id='newslist-1']/div/ul/li[1]/p[1]/a");

            Title = headLine.InnerHtml;
        }
    }
}
