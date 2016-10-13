using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;

using HttpArchive;
using HarWAPI;
using HarWAPI.Controllers;
using HarWAPI.Models;



namespace HarWAPI.Tests
{
    [TestClass]
    public class WebApiTests
    {
 

        [TestMethod]
        public async Task GetRequestsPayloadTest()
        {

            string mappath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

            if (!string.IsNullOrEmpty(mappath))
            {
                var result = await Post(mappath);

                using (var httpClient = new HttpClient())
                {

                    var requestUri = new Uri("http://localhost:49265/api/Requests/1");

                    httpClient.BaseAddress = new Uri("http://localhost:49265/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);

                    Requests reqent = null;
                    if (response.IsSuccessStatusCode)
                    {

                        reqent = await response.Content.ReadAsAsync<Requests>();

                    }

                    // Assert
                    Assert.IsNotNull(reqent);
                    Assert.AreEqual(12, reqent.requests.Count());

                }
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public async Task Get()
        {
            
            string mappath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

            if (!string.IsNullOrEmpty(mappath))
            {
                var result = await Post(mappath);

                using (var httpClient = new HttpClient())
                {

                    var requestUri = new Uri("http://localhost:49265/api/Har/1");

                    httpClient.BaseAddress = new Uri("http://localhost:49265/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);

                    HarEntity harent = null;
                    if (response.IsSuccessStatusCode)
                    {

                        harent = await response.Content.ReadAsAsync<HarEntity>();

                    }

                    // Assert
                    Assert.IsNotNull(harent);
                    Assert.AreEqual(12, harent.log.entries.Count());

                }
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public async Task Put()
        {

            string mappath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

            if (!string.IsNullOrEmpty(mappath))
            {
                var result = await Post(mappath);

                HarEntity harent = null;
                using (var httpClient = new HttpClient())
                {

                    var requestUri = new Uri("http://localhost:49265/api/Har/1");

                    httpClient.BaseAddress = new Uri("http://localhost:49265/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);

                    
                    if (response.IsSuccessStatusCode)
                    {

                        harent = await response.Content.ReadAsAsync<HarEntity>();

                    }

                    // Assert
                    Assert.IsNotNull(harent);
                    Assert.AreEqual("1.2", harent.log.version);

                    //
                    harent.log.version = "1.1";
                    HttpResponseMessage putresponse = await httpClient.PutAsJsonAsync("api/Har",harent);


                    HttpResponseMessage getresponse = await httpClient.GetAsync(requestUri);


                    if (getresponse.IsSuccessStatusCode)
                    {

                        harent = await getresponse.Content.ReadAsAsync<HarEntity>();

                    }

                    // Assert
                    Assert.IsNotNull(harent);
                    Assert.AreEqual("1.1", harent.log.version);


                }


            }
            else
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public async Task Delete()
        {

            string mappath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

            if (!string.IsNullOrEmpty(mappath))
            {
                var result = await Post(mappath);

                HarEntity harent = null;
                using (var httpClient = new HttpClient())
                {

                    var requestUri = new Uri("http://localhost:49265/api/Har/1");

                    httpClient.BaseAddress = new Uri("http://localhost:49265/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);


                    if (response.IsSuccessStatusCode)
                    {

                        harent = await response.Content.ReadAsAsync<HarEntity>();

                    }

                    // Assert
                    Assert.IsNotNull(harent);
                    Assert.AreEqual("1.2", harent.log.version);
                    Assert.AreEqual(12, harent.log.entries.Count());

                    //Delete HAR entity where Id = 1
                    HttpResponseMessage deleteresponse = await httpClient.DeleteAsync("api/Har/1");


                    if (!deleteresponse.IsSuccessStatusCode)
                    {

                        Assert.Fail();

                    }

                    HttpResponseMessage getresponse = await httpClient.GetAsync(requestUri);

                    //Deleted should not return sucess and have a StatusCode of NotFound
                    if (!getresponse.IsSuccessStatusCode)
                    {

                        Assert.AreEqual(HttpStatusCode.NotFound, getresponse.StatusCode);

                    }

                }


            }
            else
            {
                Assert.Fail();
            }
        }

        private async Task<HttpResponseMessage> Post(string mappath)
        {

            HttpResponseMessage response = null;

            if (!string.IsNullOrEmpty(mappath))
            {

                var harObj = Utility.HarConvert.DeserializeFromFile(mappath);

                using (var httpClient = new HttpClient())
                {

                    httpClient.BaseAddress = new Uri("http://localhost:49265/");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    response = await httpClient.PostAsJsonAsync<IHar>("api/Har", harObj);

                    if (response.IsSuccessStatusCode)
                    {

                        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

                    }
                    else
                    {
                        Assert.Fail();
                    }

                }
            }
            return response;
        }

    }
}
