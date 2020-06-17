using ApiTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web.Script.Serialization;

namespace EbatePackageTests
{
    class JsonForBody
    {
        public string GetJsonBody()
        {
            DateTime dateEnd = DateTime.Now;
            Random rnd = new Random();


            var obj = new ObjectBody
            {
                //{rnd.Next(0,1)}{rnd.Next(1,9)}
                type = 1,
                companyIds = new[] { "350" },
                periodId = 6,
                periodStart = "2000-01-01T00:00:00.000Z",
                periodEnd = dateEnd.AddDays(rnd.Next(1, 999)),
                description = "some description",
                budget = 1,
                target = 2,
                comments = "some comments",
                id = 0
            };

            var json = new JavaScriptSerializer().Serialize(obj);
            return json;
        }    
    }
    public class ObjectBody
    {
        public int type;
        public string[] companyIds;
        public int periodId;
        public string periodStart;
        public DateTime periodEnd;
        public string description;
        public int budget;
        public int target;
        public string comments;
        public int id;
    }    
}  