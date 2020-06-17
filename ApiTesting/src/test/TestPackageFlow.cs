using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiTesting
{
    [TestClass]
    public class TestPackageFlow
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestAddPackageAsync()
        {
            var addPackage = new PackageLogic();            
            await addPackage.TestAddPackageAsync();            

            /*
             * 
             * {
"selected":false,
"statusDescription":null,
"companyIds":null,
"company":null,
"companyType":"Customer",
"accountRef":null,
"companyName":null,
"type":1,
"description":"some description",
"comments":"some comments",
"periodId":6,
"periodDesc":"Ongoing",
"period":null,
"periodStart":"2005-01-01T00:00:00Z",
"periodEnd":"2020-06-10T16:17:33.821Z",
"status":2,
"accountTypeId":null,
"periodStartDesc":"01/01/2005",
"periodEndDesc":"10/06/2020",
"details":null,
"filesFolderId":null,
"commentListId":null,
"target":2.0,
"budget":1.0,
"id":238,
"isDeleted":false,
"creationDate":"0001-01-01T00:00:00Z",
"updateDate":null,
"creatorId":null,
"updaterId":null
}
              */
        }
    }
}