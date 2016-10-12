using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using HttpArchive;
using HarWAPI;
using HarWAPI.Controllers;
using HarWAPI.Models;
using System.Web.Http.Routing;

namespace HarWAPI.Tests.Controllers
{

    [TestClass]
    public class HarControllerTest
    {

        //Controller tests commented out, current implementation of Post accepts HttpRequestMessage request
        //to provide for some basic validation of the input JSON string



        //[TestMethod]
        //public async Task Get()
        //{

        //    // Arrange
        //    var controller = GetController();

        //    string mappath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");


        //    if (!string.IsNullOrEmpty(mappath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);


        //        string mappath2 = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");


        //        if (!string.IsNullOrEmpty(mappath2))
        //        {

        //            HarEntity harObj2 = Utility.HarConvert.DeserializeFromFile(mappath2);

        //            // Act
        //            controller.Post(harObj2);


        //            // Act
        //            IEnumerable<HarEntity> harent = controller.Get();

        //            // Assert
        //            Assert.IsNotNull(harent);
        //            Assert.AreEqual(2, harent.Count());
        //            Assert.AreEqual(12, harent.ElementAt(0).log.entries.Count());
        //            Assert.AreEqual(113, harent.ElementAt(1).log.entries.Count());


        //        }


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }

        //}


        //[TestMethod]
        //public void GetById()
        //{
        //    // Arrange
        //    var controller = GetController();

        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");


        //    if (!string.IsNullOrEmpty(MapPath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);


        //        string MapPath2 = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");


        //        if (!string.IsNullOrEmpty(MapPath2))
        //        {

        //            HarEntity harObj1 = Utility.HarConvert.DeserializeFromFile(MapPath2);

        //            // Act
        //            controller.Post(harObj1);

        //            // Act
        //            Har harent = controller.Get(2);

        //            // Assert
        //            Assert.IsNotNull(harent);
        //            Assert.AreEqual(113, harent.log.entries.Count());

        //        }


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }

        //}


        //[TestMethod]
        //public void GetHarRequestFields()
        //{

        //    // Arrange
        //    var controller = GetController();

        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");

        //    if (!string.IsNullOrEmpty(MapPath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);

        //        // Act
        //        var harreq = (from req in controller.Get(1).log.entries
        //                        select new
        //                        {
        //                            Method = req.request.Method,
        //                            url = req.request.url
        //                        }
        //                        ).ToList();


        //        // Assert
        //        Assert.IsNotNull(harreq);


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }


        //}


        //[TestMethod()]
        //public void Post()
        //{
        //    // Arrange
        //    var controller = GetController();

        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

        //    if (!string.IsNullOrEmpty(MapPath))
        //    {
        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);

        //        // Act
        //        IEnumerable<HarEntity> harent = controller.Get();

        //        // Assert
        //        Assert.IsNotNull(harent);
        //        Assert.AreEqual(1, harent.Count());
        //        Assert.AreEqual(1, harent.ElementAt(0).Id);


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }


        //}


        //[TestMethod()]
        //public void PostMultiple()
        //{
        //    // Arrange
        //    var controller = GetController();

        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");


        //    if (!string.IsNullOrEmpty(MapPath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);

        //        string MapPath2 = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");


        //        if (!string.IsNullOrEmpty(MapPath2))
        //        {

        //            HarEntity harObj1 = Utility.HarConvert.DeserializeFromFile(MapPath2);

        //            // Act
        //            controller.Post(harObj1);

        //            // Act
        //            IEnumerable<HarEntity> harent = controller.Get();

        //            // Assert
        //            Assert.IsNotNull(harent);
        //            Assert.AreEqual(2, harent.Count());

        //        }


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }


        //}


        //[TestMethod]
        //public void Put()
        //{
        //    // Arrange
        //    var controller = GetController();

        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

        //    if (!string.IsNullOrEmpty(MapPath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);

        //        // Act
        //        Har harent = controller.Get(1);

        //        // Assert
        //        Assert.IsNotNull(harent);
        //        Assert.AreEqual("1.2", harent.log.version);

        //        //change the version and update the entity
        //        harent.log.version = "1.1";
        //        controller.Put(harent);

        //        // Act
        //        Har harent1 = controller.Get(1);

        //        // Assert
        //        Assert.IsNotNull(harent1);
        //        Assert.AreEqual("1.1", harent1.log.version);

        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }
        //}


        //[TestMethod]
        //public void Delete()
        //{

        //    // Arrange
        //    var controller = GetController();


        //    string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");


        //    if (!string.IsNullOrEmpty(MapPath))
        //    {

        //        HarEntity harObj = Utility.HarConvert.DeserializeFromFile(MapPath);

        //        // Act
        //        controller.Post(harObj);

        //        string MapPath2 = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");


        //        if (!string.IsNullOrEmpty(MapPath2))
        //        {

        //            HarEntity harObj1 = Utility.HarConvert.DeserializeFromFile(MapPath2);

        //            // Act
        //            controller.Post(harObj1);

        //            // Act
        //            IEnumerable<Har> harent = controller.Get();

        //            // Assert
        //            Assert.IsNotNull(harent);
        //            Assert.AreEqual(2, harent.Count());
        //            Assert.AreEqual(12, harent.ElementAt(0).log.entries.Count());
        //            Assert.AreEqual(113, harent.ElementAt(1).log.entries.Count());

        //            //Delete item 2 and verify the count and the correct entity was deleted
        //            controller.Delete(2);

        //            // Act
        //            IEnumerable<Har> harent2 = controller.Get();

        //            // Assert
        //            Assert.IsNotNull(harent2);
        //            Assert.AreEqual(1, harent2.Count());
        //            Assert.AreEqual(12, harent2.ElementAt(0).log.entries.Count());


        //        }


        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    } 

        //}




        //private HarController GetController()
        //{
        //    // Arrange
        //    IHarRepository repository = new HarRepository();

        //    var controller = new HarController(repository);

        //    return controller;

        //}

    }
}
