using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForecastGenerator;
using ForecastGenerator.Classes;

namespace ForecastGeneratorTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void StandupTest()
        {
            var forecastDTO = new ForecastDTO(true);
            //
            Assert.IsTrue(forecastDTO.CurrentBTCValue > 0D, "Current BTC Value is zero");
            //
            Utils.LoadForecastDTO(forecastDTO);
            //Assert we have some rows with data
            Assert.IsTrue(forecastDTO.GetHistoricalRow(0).OpenAmount > 0D, "Loading Forecast DTO yielded a Zero open amount.");
            //

        }
    }
}
