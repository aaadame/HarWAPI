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
    public class RequestsController : BaseHarController
    {


        public RequestsController() : base() { }


        public RequestsController(IHarRepository harrepository) : base(harrepository) { }


        public Requests Get(int id)
        {

            Requests harrequests = null;

            var harreq = repository.GetRequests(id);

            HttpResponseMessage response = null;
            if (harreq == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                harrequests = new Requests();

                foreach (var req in harreq)
                {
                    harrequests.requests.Add(new Request() { Method = req.Method, url = req.url });
                }
            }

            return harrequests;

        }

        /// <summary>
        /// Posts the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody] HarEntity item)
        {

            item = repository.Add(item);
            HttpResponseMessage response = null;
            if (Request != null)
            {
                response = Request.CreateResponse(HttpStatusCode.Created);

                string uri = Url.Link("DefaultApi", new { id = item.Id });
                response.Headers.Location = new Uri(uri);
            }
            return response;
        }

    }
}
