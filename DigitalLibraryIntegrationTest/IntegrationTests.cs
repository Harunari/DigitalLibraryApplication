using DigitalLibraryApplication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace DigitalLibraryIntegrationTest
{
    public class IntegrationTests
    {
        public HttpClient _client;

        public IntegrationTests()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Fact]
        public async Task Description_NoCondition_Success()
        {
            var response = await _client.GetAsync("/Welcome/Description");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("This is the application for managing digital books!", responseString);
        }
    }
}
