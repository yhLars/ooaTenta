using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            title = "Test";
            _crimeHeadlineSystem.FoundCrime("Utryckning", title);
        }
    }
}
