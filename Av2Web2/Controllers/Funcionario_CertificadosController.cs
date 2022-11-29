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
    public class Funcionario_CertificadosController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Funcionario_Certificados
        public IQueryable<Funcionario_Certificados> GetFuncionario_Certificados()
        {
            return db.Funcionario_Certificados;
        }

        // GET: api/Funcionario_Certificados/5
        [ResponseType(typeof(Funcionario_Certificados))]
        public IHttpActionResult GetFuncionario_Certificados(long id)
        {
            Funcionario_Certificados funcionario_Certificados = db.Funcionario_Certificados.Find(id);
            if (funcionario_Certificados == null)
            {
                return NotFound();
            }

            return Ok(funcionario_Certificados);
        }

        // PUT: api/Funcionario_Certificados/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFuncionario_Certificados(long id, Funcionario_Certificados funcionario_Certificados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != funcionario_Certificados.NUM_Chave)
            {
                return BadRequest();
            }

            db.Entry(funcionario_Certificados).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Funcionario_CertificadosExists(id))
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

        // POST: api/Funcionario_Certificados
        [ResponseType(typeof(Funcionario_Certificados))]
        public IHttpActionResult PostFuncionario_Certificados(Funcionario_Certificados funcionario_Certificados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Funcionario_Certificados.Add(funcionario_Certificados);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = funcionario_Certificados.NUM_Chave }, funcionario_Certificados);
        }

        // DELETE: api/Funcionario_Certificados/5
        [ResponseType(typeof(Funcionario_Certificados))]
        public IHttpActionResult DeleteFuncionario_Certificados(long id)
        {
            Funcionario_Certificados funcionario_Certificados = db.Funcionario_Certificados.Find(id);
            if (funcionario_Certificados == null)
            {
                return NotFound();
            }

            db.Funcionario_Certificados.Remove(funcionario_Certificados);
            db.SaveChanges();

            return Ok(funcionario_Certificados);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Funcionario_CertificadosExists(long id)
        {
            return db.Funcionario_Certificados.Count(e => e.NUM_Chave == id) > 0;
        }
    }
}