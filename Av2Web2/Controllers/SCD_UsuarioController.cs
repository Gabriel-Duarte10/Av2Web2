using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class SCD_UsuarioController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/SCD_Usuario
        public IQueryable<SCD_Usuario> GetSCD_Usuario()
        {
            return db.SCD_Usuario;
        }

        // GET: api/SCD_Usuario/5
        [ResponseType(typeof(SCD_Usuario))]
        public IHttpActionResult GetSCD_Usuario(string id)
        {
            SCD_Usuario sCD_Usuario = db.SCD_Usuario.Find(id);
            if (sCD_Usuario == null)
            {
                return NotFound();
            }

            return Ok(sCD_Usuario);
        }

        // PUT: api/SCD_Usuario/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSCD_Usuario(string id, SCD_Usuario sCD_Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sCD_Usuario.TXT_Login)
            {
                return BadRequest();
            }

            db.Entry(sCD_Usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SCD_UsuarioExists(id))
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

        // POST: api/SCD_Usuario
        [ResponseType(typeof(SCD_Usuario))]
        public IHttpActionResult PostSCD_Usuario(SCD_Usuario sCD_Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SCD_Usuario.Add(sCD_Usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SCD_UsuarioExists(sCD_Usuario.TXT_Login))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sCD_Usuario.TXT_Login }, sCD_Usuario);
        }

        // DELETE: api/SCD_Usuario/5
        [ResponseType(typeof(SCD_Usuario))]
        public IHttpActionResult DeleteSCD_Usuario(string id)
        {
            SCD_Usuario sCD_Usuario = db.SCD_Usuario.Find(id);
            if (sCD_Usuario == null)
            {
                return NotFound();
            }

            db.SCD_Usuario.Remove(sCD_Usuario);
            db.SaveChanges();

            return Ok(sCD_Usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SCD_UsuarioExists(string id)
        {
            return db.SCD_Usuario.Count(e => e.TXT_Login == id) > 0;
        }
    }
}