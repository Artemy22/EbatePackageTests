using System;
using EbatePackageTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ApiTesting
{
    class Token   
    {             
        public async System.Threading.Tasks.Task<string> GetAccessTokenAsync()
        {
            var client = new RestClient("https://app.test.e-bate.net/api/accountmanagement/login")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var authorization = new ConverterObJson();
            request.AddParameter("application/json", authorization.GetJsonForLogin(), ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            dynamic respObj = JObject.Parse(response.Content);
            string accessToken = respObj.data.accessToken;
            if (accessToken != null)
            {
                return (accessToken);
            }
            else
            {
                await GetAccessTokenAsync();
                if (accessToken != null)
                {
                    return (accessToken);
                }
                else
                {
                    await GetAccessTokenAsync();
                    return (accessToken);
                }
            }
        }
    }
}