using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModernPOS.WebAPI.Controllers
{
    /// <summary>
    /// Clients Controller
    /// </summary>
    public class ClientController : ApiController
    {
        // GET api/client
        /// <summary>
        /// Gets all the clients from the DB.
        /// </summary>
        /// <returns>Array of Clients</returns>
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "client 1", "client 2" });
        }

        // GET api/client/5
        /// <summary>
        /// Gets a client from the DB.
        /// </summary>
        /// <param name="id">Client's ID</param>
        /// <returns>A Client</returns>
        public IHttpActionResult Get(int id)
        {
            return Ok("client 1");
        }

        // POST api/client
        /// <summary>
        /// Posts a client to the DB.
        /// </summary>
        /// <param name="client">A Client</param>
        public IHttpActionResult Post([FromBody]string client)
        {
            return Ok();
        }

        // PUT api/client/5
        /// <summary>
        /// Updates a client in the DB.
        /// </summary>
        /// <param name="id">Client's ID</param>
        /// <param name="client">New data for the client</param>
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE api/client/5
        /// <summary>
        /// Deletes a client from the DB.
        /// </summary>
        /// <param name="id">Client's ID</param>
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
