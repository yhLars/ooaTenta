using System.Diagnostics.Contracts;
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

            CrimeHeadlineSystem crimeHeadlineSystem = new CrimeHeadlineSystem();

            IScreenScraperFactory screenScraperFactory = new ScreenScraperFactory();
            IScreenScraperService polisenScraper = screenScraperFactory.CreateFactory("polisen", crimeHeadlineSystem);

            // Act
            string actualHeadLine = polisenScraper.ReadTopCrime();

            // Assert
            // Check that the headline is NOT string.Empty
            Assert.AreNotEqual(unexpectedHeadLine, actualHeadLine);
        }

        [TestMethod]
        public void Test_ReadTopCrime_From_Utryckning()
        {
            // Arrange
            string unexpectedHeadLine = string.Empty;
            CrimeHeadlineSystem crimeHeadlineSystem = new CrimeHeadlineSystem();

            IScreenScraperFactory screenScraperFactory = new ScreenScraperFactory();
            IScreenScraperService utryckningScraper = screenScraperFactory.CreateFactory("utryckning", crimeHeadlineSystem);

            // Act
            string actualHeadLine = utryckningScraper.ReadTopCrime();

            // Assert
            // Check that the headline is NOT string.Empty
            Assert.AreNotEqual(unexpectedHeadLine, actualHeadLine);
        }

    }
}
