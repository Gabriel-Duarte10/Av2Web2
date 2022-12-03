using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Av2Web2.Models;

namespace Av2Web2.Controllers
{
    public class Plano_De_ContaController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Plano_De_Conta
        public IQueryable<Plano_De_Conta> GetPlano_De_Conta()
        {
            return db.Plano_De_Conta;
        }

        // GET: api/Plano_De_Conta/5
        [ResponseType(typeof(Plano_De_Conta))]
        public IHttpActionResult GetPlano_De_Conta(string id)
        {
            Plano_De_Conta plano_De_Conta = db.Plano_De_Conta.Find(id);
            if (plano_De_Conta == null)
            {
                return NotFound();
            }

            return Ok(plano_De_Conta);
        }

        // PUT: api/Plano_De_Conta/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlano_De_Conta(string id, Plano_De_Conta plano_De_Conta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plano_De_Conta.TXT_Plano_Conta)
            {
                return BadRequest();
            }

            db.Entry(plano_De_Conta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Plano_De_ContaExists(id))
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

        // POST: api/Plano_De_Conta
        [ResponseType(typeof(Plano_De_Conta))]
        public IHttpActionResult PostPlano_De_Conta(Plano_De_Conta plano_De_Conta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Plano_De_Conta.Add(plano_De_Conta);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Plano_De_ContaExists(plano_De_Conta.TXT_Plano_Conta))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = plano_De_Conta.TXT_Plano_Conta }, plano_De_Conta);
        }

        // DELETE: api/Plano_De_Conta/5
        [ResponseType(typeof(Plano_De_Conta))]
        public IHttpActionResult DeletePlano_De_Conta(string id)
        {
            Plano_De_Conta plano_De_Conta = db.Plano_De_Conta.Find(id);
            if (plano_De_Conta == null)
            {
                return NotFound();
            }

            db.Plano_De_Conta.Remove(plano_De_Conta);
            db.SaveChanges();

            return Ok(plano_De_Conta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Plano_De_ContaExists(string id)
        {
            return db.Plano_De_Conta.Count(e => e.TXT_Plano_Conta == id) > 0;
        }
    }
}