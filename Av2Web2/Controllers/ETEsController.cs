using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class ETEsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/ETEs
        public IQueryable<ETE> GetETE()
        {
            return db.ETE;
        }

        // GET: api/ETEs/5
        [ResponseType(typeof(ETE))]
        public IHttpActionResult GetETE(long id)
        {
            ETE eTE = db.ETE.Find(id);
            if (eTE == null)
            {
                return NotFound();
            }

            return Ok(eTE);
        }

        // PUT: api/ETEs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutETE(long id, ETE eTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTE.NUM_ETE)
            {
                return BadRequest();
            }

            db.Entry(eTE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETEExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ETEs
        [ResponseType(typeof(ETE))]
        public IHttpActionResult PostETE(ETE eTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETE.Add(eTE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eTE.NUM_ETE }, eTE);
        }

        // DELETE: api/ETEs/5
        [ResponseType(typeof(ETE))]
        public IHttpActionResult DeleteETE(long id)
        {
            ETE eTE = db.ETE.Find(id);
            if (eTE == null)
            {
                return NotFound();
            }

            db.ETE.Remove(eTE);
            db.SaveChanges();

            return Ok(eTE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETEExists(long id)
        {
            return db.ETE.Count(e => e.NUM_ETE == id) > 0;
        }
    }
}