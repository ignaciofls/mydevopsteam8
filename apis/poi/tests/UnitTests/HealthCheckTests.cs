using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            Assert.Equal("POI Service Healthcheck", new Healthcheck().Message.Substring(0, 23));
            Assert.Equal("Healthy", new Healthcheck().Status);

        }
    }
}
