﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            title = "Test";
            _crimeHeadlineSystem.FoundCrime("Polisen", title);
        }
    }
}