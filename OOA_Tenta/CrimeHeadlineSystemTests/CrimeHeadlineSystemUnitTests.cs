using System;
using CrimeHeadlineSystemLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrimeHeadlineSystemTests
{
    [TestClass]
    public class CrimeHeadlineSystemUnitTests
    {
        [TestMethod]
        public void Test_ReadTopCrime_From_Polisen()
        {
            // Arrange
            string unexpectedHeadLine = string.Empty;

            // Act
            CrimeHeadlineSystem crimeHeadlineSystem = new CrimeHeadlineSystem();
            PolisenScraper polisenScraper = new PolisenScraper(crimeHeadlineSystem);

            polisenScraper.ReadTopCrime();

            string actualHeadLine = polisenScraper.title;

            // Assert
            Assert.AreNotEqual(unexpectedHeadLine, actualHeadLine);
        }

        [TestMethod]
        public void Test_ReadTopCrime_From_Utryckning()
        {
            // Arrange
            string unexpectedHeadLine = string.Empty;

            // Act
            CrimeHeadlineSystem crimeHeadlineSystem = new CrimeHeadlineSystem();
            UtryckningScraper utryckningScraper = new UtryckningScraper(crimeHeadlineSystem);

            utryckningScraper.ReadTopCrime();

            string actualHeadLine = utryckningScraper.title;

            // Assert
            Assert.AreNotEqual(unexpectedHeadLine, actualHeadLine);
        }

    }
}
