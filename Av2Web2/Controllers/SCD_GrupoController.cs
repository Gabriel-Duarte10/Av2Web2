using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class SCD_GrupoController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/SCD_Grupo
        public IQueryable<SCD_Grupo> GetSCD_Grupo()
        {
            return db.SCD_Grupo;
        }

        // GET: api/SCD_Grupo/5
        [ResponseType(typeof(SCD_Grupo))]
        public IHttpActionResult GetSCD_Grupo(int id)
        {
            SCD_Grupo sCD_Grupo = db.SCD_Grupo.Find(id);
            if (sCD_Grupo == null)
            {
                return NotFound();
            }

            return Ok(sCD_Grupo);
        }

        // PUT: api/SCD_Grupo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSCD_Grupo(int id, SCD_Grupo sCD_Grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sCD_Grupo.NUM_Grupo)
            {
                return BadRequest();
            }

            db.Entry(sCD_Grupo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SCD_GrupoExists(id))
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

        // POST: api/SCD_Grupo
        [ResponseType(typeof(SCD_Grupo))]
        public IHttpActionResult PostSCD_Grupo(SCD_Grupo sCD_Grupo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SCD_Grupo.Add(sCD_Grupo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SCD_GrupoExists(sCD_Grupo.NUM_Grupo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sCD_Grupo.NUM_Grupo }, sCD_Grupo);
        }

        // DELETE: api/SCD_Grupo/5
        [ResponseType(typeof(SCD_Grupo))]
        public IHttpActionResult DeleteSCD_Grupo(int id)
        {
            SCD_Grupo sCD_Grupo = db.SCD_Grupo.Find(id);
            if (sCD_Grupo == null)
            {
                return NotFound();
            }

            db.SCD_Grupo.Remove(sCD_Grupo);
            db.SaveChanges();

            return Ok(sCD_Grupo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SCD_GrupoExists(int id)
        {
            return db.SCD_Grupo.Count(e => e.NUM_Grupo == id) > 0;
        }
    }
}