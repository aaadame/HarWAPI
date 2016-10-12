using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using HarWAPI.Models;
using HttpArchive;

namespace HarWAPI.Controllers
{
    //[Authorize]
    public class HarController : ApiController
    {

        static IHarRepository repository;

        public HarController()
        {
            if (repository == null)
                { repository = new HarRepository(); }
        }

        public HarController(IHarRepository harrepository)
        {
            repository = harrepository;
        }

        /// <summary>
        /// Read all
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HarEntity> Get()
        {
            return repository.Get();
        }

        /// <summary>
        /// Read by index
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="HttpResponseException"></exception>
        public HarEntity Get(int id)
        {
            HarEntity item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        /// <summary>
        /// Posts the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            var jsonString = await request.Content.ReadAsStringAsync();

            HarEntity item = repository.Add(jsonString);
            HttpResponseMessage response = null;
            if (Request != null)
            {
                response = Request.CreateResponse(HttpStatusCode.Created);

                string uri = Url.Link("DefaultApi", new { id = item.Id });
                response.Headers.Location = new Uri(uri);
            }
            return response;

        }

        //public HttpResponseMessage Post([FromBody] Har item)
        //{

        //    item = repository.Add(item);
        //    HttpResponseMessage response = null;
        //    if (Request != null)
        //    {
        //        response = Request.CreateResponse(HttpStatusCode.Created);

        //        string uri = Url.Link("DefaultApi", new { id = item.Id });
        //        response.Headers.Location = new Uri(uri);
        //    }
        //    return response;
        //}

        /// <summary>
        /// Update 
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="har">The har.</param>
        /// <exception cref="HttpResponseException"></exception>
        public void Put(HarEntity har)
        {
            if (!repository.Update(har))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="HttpResponseException"></exception>
        public void Delete(int id)
        {
            HarEntity item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }

        /// <summary>
        /// Gets the har requests.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="HttpResponseException"></exception>
        //[HttpGet, ActionName("HarRequests")]
        //public IEnumerable<Request> GetRequests(int id)
        //{

        //    var harreq = (from req in repository.GetRequests(id)
        //                  select new Request
        //                  {
        //                      Method = req.Method,
        //                      url = req.url
        //                  }
        //                  ).ToList();


        //    HttpResponseMessage response = null;
        //    if (harreq == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    return harreq;

        //}


    }
}
