using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class Tipo_RecebimentoController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Tipo_Recebimento
        public IQueryable<Tipo_Recebimento> GetTipo_Recebimento()
        {
            return db.Tipo_Recebimento;
        }

        // GET: api/Tipo_Recebimento/5
        [ResponseType(typeof(Tipo_Recebimento))]
        public IHttpActionResult GetTipo_Recebimento(string id)
        {
            Tipo_Recebimento tipo_Recebimento = db.Tipo_Recebimento.Find(id);
            if (tipo_Recebimento == null)
            {
                return NotFound();
            }

            return Ok(tipo_Recebimento);
        }

        // PUT: api/Tipo_Recebimento/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipo_Recebimento(string id, Tipo_Recebimento tipo_Recebimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_Recebimento.TXT_Recebimento)
            {
                return BadRequest();
            }

            db.Entry(tipo_Recebimento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_RecebimentoExists(id))
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

        // POST: api/Tipo_Recebimento
        [ResponseType(typeof(Tipo_Recebimento))]
        public IHttpActionResult PostTipo_Recebimento(Tipo_Recebimento tipo_Recebimento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tipo_Recebimento.Add(tipo_Recebimento);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Tipo_RecebimentoExists(tipo_Recebimento.TXT_Recebimento))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tipo_Recebimento.TXT_Recebimento }, tipo_Recebimento);
        }

        // DELETE: api/Tipo_Recebimento/5
        [ResponseType(typeof(Tipo_Recebimento))]
        public IHttpActionResult DeleteTipo_Recebimento(string id)
        {
            Tipo_Recebimento tipo_Recebimento = db.Tipo_Recebimento.Find(id);
            if (tipo_Recebimento == null)
            {
                return NotFound();
            }

            db.Tipo_Recebimento.Remove(tipo_Recebimento);
            db.SaveChanges();

            return Ok(tipo_Recebimento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Tipo_RecebimentoExists(string id)
        {
            return db.Tipo_Recebimento.Count(e => e.TXT_Recebimento == id) > 0;
        }
    }
}