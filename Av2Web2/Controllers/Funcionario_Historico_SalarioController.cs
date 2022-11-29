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
    public class Funcionario_Historico_SalarioController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Funcionario_Historico_Salario
        public IQueryable<Funcionario_Historico_Salario> GetFuncionario_Historico_Salario()
        {
            return db.Funcionario_Historico_Salario;
        }

        // GET: api/Funcionario_Historico_Salario/5
        [ResponseType(typeof(Funcionario_Historico_Salario))]
        public IHttpActionResult GetFuncionario_Historico_Salario(long id)
        {
            Funcionario_Historico_Salario funcionario_Historico_Salario = db.Funcionario_Historico_Salario.Find(id);
            if (funcionario_Historico_Salario == null)
            {
                return NotFound();
            }

            return Ok(funcionario_Historico_Salario);
        }

        // PUT: api/Funcionario_Historico_Salario/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFuncionario_Historico_Salario(long id, Funcionario_Historico_Salario funcionario_Historico_Salario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != funcionario_Historico_Salario.NUM_Chave)
            {
                return BadRequest();
            }

            db.Entry(funcionario_Historico_Salario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Funcionario_Historico_SalarioExists(id))
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

        // POST: api/Funcionario_Historico_Salario
        [ResponseType(typeof(Funcionario_Historico_Salario))]
        public IHttpActionResult PostFuncionario_Historico_Salario(Funcionario_Historico_Salario funcionario_Historico_Salario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Funcionario_Historico_Salario.Add(funcionario_Historico_Salario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = funcionario_Historico_Salario.NUM_Chave }, funcionario_Historico_Salario);
        }

        // DELETE: api/Funcionario_Historico_Salario/5
        [ResponseType(typeof(Funcionario_Historico_Salario))]
        public IHttpActionResult DeleteFuncionario_Historico_Salario(long id)
        {
            Funcionario_Historico_Salario funcionario_Historico_Salario = db.Funcionario_Historico_Salario.Find(id);
            if (funcionario_Historico_Salario == null)
            {
                return NotFound();
            }

            db.Funcionario_Historico_Salario.Remove(funcionario_Historico_Salario);
            db.SaveChanges();

            return Ok(funcionario_Historico_Salario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Funcionario_Historico_SalarioExists(long id)
        {
            return db.Funcionario_Historico_Salario.Count(e => e.NUM_Chave == id) > 0;
        }
    }
}