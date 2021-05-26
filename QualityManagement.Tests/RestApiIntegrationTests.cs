using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using QualityManagement.API;
using QualityManagement.Shared;
using Xunit;

namespace QualityManagement.Tests
{
    public class RestApiIntegrationTests
    {
        private readonly HttpClient _client;

        public RestApiIntegrationTests() {
            _client = new TestServer(new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>())
                .CreateClient();
        }

        [Theory]
        [InlineData("a a a b b b a a a b b b a a a")]
        public async Task TestApiGetMethod(string requestText) {
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/pieceoftext/" + requestText);
            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var data = new BasicEnvironment();
            Assert.Equal(data.TestData1.Results.ToSimpleText(), result);
        }
    }
}