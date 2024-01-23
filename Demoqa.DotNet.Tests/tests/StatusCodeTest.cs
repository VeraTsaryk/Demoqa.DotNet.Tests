using Demoqa.DotNet.Tests.PageObject;
using RestSharp;
using System.Net;
using Demoqa.DotNet.Tests.Constants;

namespace Demoqa.DotNet.Tests.tests
{
    internal class StatusCodeTest: BaseTest<StatusCodePage>
    {
        private RestClient _client;

        [SetUp]
        public new void Setup()
        {
            _client = new RestClient(Url.FailedErrorUrl);
            page = new StatusCodePage(driver);
            page.OpenPage(Url.StatusCodeUrl);
        }

        [Test]
        public void CheckStatusCodeIsEqual500()
        {
            page.StatusCode();
            RestRequest request = new RestRequest(Url.FailedErrorUrl, Method.Get);
            var responce = _client.Execute<string>(request);
            Assert.That(responce.StatusCode, Is.EqualTo(HttpStatusCode.InternalServerError));
        }


    }
}
