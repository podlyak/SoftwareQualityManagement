using Xunit;
using QualityManagement.API.Controllers;
using QualityManagement.Shared;

namespace QualityManagement.Tests
{
    public class RestAPITests
    {
        [Theory]
        [InlineData("a a a b b b a a a b b b a a a")]
        public async void TestTextIndex(string request)
        {
            var controller = new PieceOfTextController();
            string result = await controller.Get(request);
            var data = new BasicEnvironment();
            Assert.Equal(data.TestData1.Results.ToSimpleText(), result);
        }
    }
}