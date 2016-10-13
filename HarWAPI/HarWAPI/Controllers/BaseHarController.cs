using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HarWAPI.Models;
using HttpArchive;


namespace HarWAPI.Controllers
{
    public class BaseHarController : ApiController
    {

        public static IHarRepository repository;

        public BaseHarController()
        {
            if (repository == null)
            { repository = new HarRepository(); }
        }

        public BaseHarController(IHarRepository harrepository)
        {
            repository = harrepository;
        }

    }
}
