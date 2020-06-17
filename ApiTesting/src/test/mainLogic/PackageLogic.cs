using System;
using EbatePackageTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;

namespace ApiTesting
{    
    public class PackageLogic
    {        
        public async System.Threading.Tasks.Task TestAddPackageAsync()
        {
            var token = new Token();
            var accToken = await token.GetAccessTokenAsync();
            Thread.Sleep(3000);            
            //Timeout = -1;
            var jsonBody = new JsonForBody();
            var client = new RestClient("https://app.test.e-bate.net/api/Package");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept", "application/json, text/plain, */*");
            request.AddHeader("Authorization", $"Bearer {accToken}");
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36";
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Origin", "https://app.test.e-bate.net");
            request.AddHeader("Sec-Fetch-Site", "same-origin");
            request.AddHeader("Sec-Fetch-Mode", "cors");
            request.AddHeader("Referer", "https://app.test.e-bate.net/package");
            request.AddParameter("application/json", jsonBody.GetJsonBody(), ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);  
        }
    }
}