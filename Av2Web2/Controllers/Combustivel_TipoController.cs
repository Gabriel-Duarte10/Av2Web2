using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class Combustivel_TipoController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Combustivel_Tipo
        public IQueryable<Combustivel_Tipo> GetCombustivel_Tipo()
        {
            return db.Combustivel_Tipo;
        }

        // GET: api/Combustivel_Tipo/5
        [ResponseType(typeof(Combustivel_Tipo))]
        public IHttpActionResult GetCombustivel_Tipo(long id)
        {
            Combustivel_Tipo combustivel_Tipo = db.Combustivel_Tipo.Find(id);
            if (combustivel_Tipo == null)
            {
                return NotFound();
            }

            return Ok(combustivel_Tipo);
        }

        // PUT: api/Combustivel_Tipo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCombustivel_Tipo(long id, Combustivel_Tipo combustivel_Tipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != combustivel_Tipo.NUM_Combustivel)
            {
                return BadRequest();
            }

            db.Entry(combustivel_Tipo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Combustivel_TipoExists(id))
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

        // POST: api/Combustivel_Tipo
        [ResponseType(typeof(Combustivel_Tipo))]
        public IHttpActionResult PostCombustivel_Tipo(Combustivel_Tipo combustivel_Tipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Combustivel_Tipo.Add(combustivel_Tipo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = combustivel_Tipo.NUM_Combustivel }, combustivel_Tipo);
        }

        // DELETE: api/Combustivel_Tipo/5
        [ResponseType(typeof(Combustivel_Tipo))]
        public IHttpActionResult DeleteCombustivel_Tipo(long id)
        {
            Combustivel_Tipo combustivel_Tipo = db.Combustivel_Tipo.Find(id);
            if (combustivel_Tipo == null)
            {
                return NotFound();
            }

            db.Combustivel_Tipo.Remove(combustivel_Tipo);
            db.SaveChanges();

            return Ok(combustivel_Tipo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Combustivel_TipoExists(long id)
        {
            return db.Combustivel_Tipo.Count(e => e.NUM_Combustivel == id) > 0;
        }
    }
}