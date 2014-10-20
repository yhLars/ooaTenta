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
            PolisenScraper polisenScraper = new PolisenScraper(crimeHeadlineSystem);

            // Act
            polisenScraper.ReadTopCrime();
            string actualHeadLine = polisenScraper.Title;

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
            UtryckningScraper utryckningScraper = new UtryckningScraper(crimeHeadlineSystem);

            // Act
            utryckningScraper.ReadTopCrime();
            string actualHeadLine = utryckningScraper.Title;

            // Assert
            // Check that the headline is NOT string.Empty
            Assert.AreNotEqual(unexpectedHeadLine, actualHeadLine);
        }

    }
}
