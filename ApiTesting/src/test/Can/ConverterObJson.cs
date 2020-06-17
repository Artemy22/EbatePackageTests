using ApiTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web.Script.Serialization;

namespace EbatePackageTests
{
    class ConverterObJson
    {        
        public string GetJsonForLogin()
        {
            var creds = new Credentials();

            var obj = new ObjectForToken
            {
                email = creds.Email,
                password = creds.Password,
                tenantId = 1
            };

            var json = new JavaScriptSerializer().Serialize(obj);
            return json;
        }
        
    }
    public class ObjectForToken
    {
        public string email;
        public string password;
        public int tenantId;
    }    
}

    