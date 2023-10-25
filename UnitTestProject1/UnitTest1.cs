using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpClient client = new HttpClient();
            string dataUri = "https://localhost:44385/api/data/index";
            HttpResponseMessage response = client.GetAsync(dataUri).Result;
            string ser_result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(ser_result);
            Assert.AreEqual(1, 1);
        }
    }
}
