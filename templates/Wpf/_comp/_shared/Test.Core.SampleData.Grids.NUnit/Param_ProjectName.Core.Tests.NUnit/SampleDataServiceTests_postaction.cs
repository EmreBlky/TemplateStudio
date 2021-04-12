﻿namespace Param_RootNamespace.Core.Tests.NUnit
{
    public class SampleDataServiceTests
    {
        //^^
        //{[{

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [Test]
        public async Task EnsureSampleDataServiceReturnsGridDataAsync()
        {
            var sampleDataService = new SampleDataService();

            var data = await sampleDataService.GetGridDataAsync();

            Assert.IsTrue(data.Any());
        }
        //}]}
    }
}
