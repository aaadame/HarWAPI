using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HttpArchive;
using HarWAPI;
using HarWAPI.Controllers;
using HarWAPI.Models;

namespace HarWAPI.Tests.Controllers
{
    [TestClass]
    public class RequestsControllerTest
    {

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = GetController();

            string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");


            if (!string.IsNullOrEmpty(MapPath))
            {

                HarEntity harObj = (HarEntity)Utility.HarConvert.DeserializeFromFile(MapPath);

                // Act
                controller.Post(harObj);


                string MapPath2 = Utility.Utils.GetMapPath(@".\Resources\Sample2.har");


                if (!string.IsNullOrEmpty(MapPath2))
                {

                    HarEntity harObj1 = (HarEntity)Utility.HarConvert.DeserializeFromFile(MapPath2);

                    // Act
                    controller.Post(harObj1);

                    // Act
                    Requests reqent = controller.Get(2);

                    // Assert
                    Assert.IsNotNull(reqent);
                    Assert.AreEqual(113, reqent.requests.Count());

                }


            }
            else
            {
                Assert.Fail();
            }

        }


        [TestMethod()]
        public void Post()
        {
            // Arrange
            var controller = GetController();

            string MapPath = Utility.Utils.GetMapPath(@".\Resources\Sample1.har");

            if (!string.IsNullOrEmpty(MapPath))
            {
                HarEntity harObj = (HarEntity)Utility.HarConvert.DeserializeFromFile(MapPath);

                // Act
                controller.Post(harObj);

                // Act
                Requests reqent = controller.Get(1);

                // Assert
                Assert.IsNotNull(reqent);
                Assert.AreEqual(12, reqent.requests.Count());
               

            }
            else
            {
                Assert.Fail();
            }


        }


        private RequestsController GetController()
        {
            // Arrange
            IHarRepository repository = new HarRepository();

            var controller = new RequestsController(repository);

            return controller;

        }


    }
}
