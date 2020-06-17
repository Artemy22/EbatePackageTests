using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Threading;
using RestSharp;
using RestSharp.Authenticators;

namespace EbatePackageTests
{
    public class apiTestFisrtTry
    {
       

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var client = new RestClient("https://api.twitter.com/1.1");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            var response = client.Get(request);
        }
        [TearDown]
        public void Teardown()
        {
           
        }
    }
}