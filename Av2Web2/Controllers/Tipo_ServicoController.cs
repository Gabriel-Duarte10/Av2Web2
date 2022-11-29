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
    public class Tipo_ServicoController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Tipo_Servico
        public IQueryable<Tipo_Servico> GetTipo_Servico()
        {
            return db.Tipo_Servico;
        }

        // GET: api/Tipo_Servico/5
        [ResponseType(typeof(Tipo_Servico))]
        public IHttpActionResult GetTipo_Servico(long id)
        {
            Tipo_Servico tipo_Servico = db.Tipo_Servico.Find(id);
            if (tipo_Servico == null)
            {
                return NotFound();
            }

            return Ok(tipo_Servico);
        }

        // PUT: api/Tipo_Servico/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipo_Servico(long id, Tipo_Servico tipo_Servico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_Servico.NUM_Servico)
            {
                return BadRequest();
            }

            db.Entry(tipo_Servico).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_ServicoExists(id))
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

        // POST: api/Tipo_Servico
        [ResponseType(typeof(Tipo_Servico))]
        public IHttpActionResult PostTipo_Servico(Tipo_Servico tipo_Servico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tipo_Servico.Add(tipo_Servico);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipo_Servico.NUM_Servico }, tipo_Servico);
        }

        // DELETE: api/Tipo_Servico/5
        [ResponseType(typeof(Tipo_Servico))]
        public IHttpActionResult DeleteTipo_Servico(long id)
        {
            Tipo_Servico tipo_Servico = db.Tipo_Servico.Find(id);
            if (tipo_Servico == null)
            {
                return NotFound();
            }

            db.Tipo_Servico.Remove(tipo_Servico);
            db.SaveChanges();

            return Ok(tipo_Servico);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Tipo_ServicoExists(long id)
        {
            return db.Tipo_Servico.Count(e => e.NUM_Servico == id) > 0;
        }
    }
}