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
    public class FornecedorsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Fornecedors
        public IQueryable<Fornecedor> GetFornecedor()
        {
            return db.Fornecedor;
        }

        // GET: api/Fornecedors/5
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult GetFornecedor(string id)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return Ok(fornecedor);
        }

        // PUT: api/Fornecedors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFornecedor(string id, Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fornecedor.TXT_Fornecedor)
            {
                return BadRequest();
            }

            db.Entry(fornecedor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(id))
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

        // POST: api/Fornecedors
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult PostFornecedor(Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fornecedor.Add(fornecedor);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FornecedorExists(fornecedor.TXT_Fornecedor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fornecedor.TXT_Fornecedor }, fornecedor);
        }

        // DELETE: api/Fornecedors/5
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult DeleteFornecedor(string id)
        {
            Fornecedor fornecedor = db.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            db.Fornecedor.Remove(fornecedor);
            db.SaveChanges();

            return Ok(fornecedor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FornecedorExists(string id)
        {
            return db.Fornecedor.Count(e => e.TXT_Fornecedor == id) > 0;
        }
    }
}