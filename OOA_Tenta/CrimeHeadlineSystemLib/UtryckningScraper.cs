using HtmlAgilityPack;

namespace CrimeHeadlineSystemLib
{
    public class UtryckningScraper : ScraperBase
    {
        private CrimeHeadlineSystem _crimeHeadlineSystem;
        public string Title = string.Empty;

        public UtryckningScraper(CrimeHeadlineSystem crimeHeadlineSystem)
        {
            _crimeHeadlineSystem = crimeHeadlineSystem;
            _crimeHeadlineSystem.RegisterUtryckningScraper(this);
        }

        public override string ScrapeUrl
        {
            get { return "http://orebrotribune.se/utryckning-se/"; }
        }

        public override string xPath
        {
            get { return @"//*[@id='homepage']/div[1]/div[1]/h1/a"; }
        }

        public override string ReadTopCrime()
        {
            return _crimeHeadlineSystem.FoundCrime("Utryckning", GetHeadLine());
        }
    }

    //public class UtryckningScraper
    //{
    //    private CrimeHeadlineSystem _crimeHeadlineSystem;
    //    public string Title = string.Empty;
    //    private const string Url = @"http://orebrotribune.se/utryckning-se/";

    //    public UtryckningScraper(CrimeHeadlineSystem crimeHeadlineSystem)
    //    {
    //        _crimeHeadlineSystem = crimeHeadlineSystem;
    //        _crimeHeadlineSystem.RegisterUtryckningScraper(this);
    //    }

    //    public void ReadTopCrime()
    //    {
    //        GetUtryckningHeadLines();
    //        _crimeHeadlineSystem.FoundCrime("Utryckning", Title);
    //    }

    //    private void GetUtryckningHeadLines()
    //    {
    //        HtmlWeb htmlWeb = new HtmlWeb();
    //        HtmlDocument htmlDocument = htmlWeb.Load(Url);

    //        HtmlNode headLine = htmlDocument.DocumentNode.SelectSingleNode(@"//*[@id='homepage']/div[1]/div[1]/h1/a");

    //        Title = headLine.InnerHtml;
    //    }

    //}
}
