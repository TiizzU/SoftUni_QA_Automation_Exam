namespace FirstTaskIntegrationTests
{
    using NUnit.Framework;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class BaseTest
    {
        public HttpClient Client;
        public Guid userId;


        [SetUp]
        public void Setup()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("https://libraryexam.azurewebsites.net/");

            userId = new Guid("7cb11f2f-0335-4008-a7a2-21b092644059");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}