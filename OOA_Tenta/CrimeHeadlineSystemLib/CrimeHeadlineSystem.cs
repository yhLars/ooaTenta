using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystemLib
{
    public class CrimeHeadlineSystem
    {
        private PolisenScraper _polisenScraper;
        private UtryckningScraper _utryckningScraper;

        internal void RegisterPolisenScraper(PolisenScraper polisenScraper)
        {
            _polisenScraper = polisenScraper;
            Debug.WriteLine("PolisenScraper is registered.");
        }
        internal void RegisterUtryckningScraper(UtryckningScraper utryckningScraper)
        {
            _utryckningScraper = utryckningScraper;
            Debug.WriteLine("UtryckningScraper is registered.");
        }

        internal void FoundCrime(string site, string title)
        {
            Console.WriteLine("Site:  '" + site + "'");
            Console.WriteLine("Title: '" + title + "'");
        }
    }
}
