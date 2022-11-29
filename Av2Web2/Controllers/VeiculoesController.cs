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
    public class VeiculoesController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Veiculoes
        public IQueryable<Veiculo> GetVeiculo()
        {
            return db.Veiculo;
        }

        // GET: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult GetVeiculo(string id)
        {
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(veiculo);
        }

        // PUT: api/Veiculoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVeiculo(string id, Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculo.TXT_Placa)
            {
                return BadRequest();
            }

            db.Entry(veiculo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
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

        // POST: api/Veiculoes
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult PostVeiculo(Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculo.Add(veiculo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (VeiculoExists(veiculo.TXT_Placa))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = veiculo.TXT_Placa }, veiculo);
        }

        // DELETE: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public IHttpActionResult DeleteVeiculo(string id)
        {
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            db.Veiculo.Remove(veiculo);
            db.SaveChanges();

            return Ok(veiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(string id)
        {
            return db.Veiculo.Count(e => e.TXT_Placa == id) > 0;
        }
    }
}