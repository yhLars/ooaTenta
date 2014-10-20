using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class ScreenScraperFactory : IScreenScraperFactory
    {
        public IScreenScraperService CreateFactory(string type)
        {
            IScreenScraperService screenScraperService = null;
            CrimeHeadlineSystem crimeHeadlineSystem = new CrimeHeadlineSystem();

            switch (type)
            {
                case "polisen":
                    screenScraperService = new PolisenScraper(crimeHeadlineSystem);
                    break;

                case "utryckning":
                    screenScraperService = new UtryckningScraper(crimeHeadlineSystem);
                    break;

                default:
                    break;
            }

            return screenScraperService;
        }
    }
}
