﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using CadastroEmpresasLibrary.Classes;
using Microsoft.Data.OData;

namespace CadastroEmpresasLibrary.Classes
{
    public class PessoaFisicaController : ApiController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/PessoaFisicas
        public async Task<IHttpActionResult> GetPessoaFisicas([FromUri]string sort, [FromUri]string order)
        {
            // validate the query.
            try
            {
                //queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }
            List<PessoaFisica> re = new PessoaFisica().GetAll();
            if (order == "asc")
            {
                switch (sort)
                {
                    case "PessoaFisicaId":
                        re = re.OrderBy(o => o.PessoaFisicaId).ToList();
                        break;
                    case "Nome":
                        re = re.OrderBy(o => o.Nome).ToList();
                        break;
                    case "DataNascimento":
                        re = re.OrderBy(o => o.DataNascimento).ToList();
                        break;
                    default:
                        break;
                }
            }
            else if (order == "desc")
            {
                switch (sort)
                {
                    case "PessoaFisicaId":
                        re = re.OrderByDescending(o => o.PessoaFisicaId).ToList();
                        break;
                    case "Nome":
                        re = re.OrderByDescending(o => o.Nome).ToList();
                        break;
                    case "DataNascimento":
                        re = re.OrderByDescending(o => o.DataNascimento).ToList();
                        break;
                    default:
                        break;
                }
            }
            return Ok(re);
        }

        // GET: odata/PessoaFisicas(5)
        public async Task<IHttpActionResult> GetPessoaFisica([FromODataUri] int key, ODataQueryOptions<PessoaFisica> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<PessoaFisica>(PessoaFisica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/PessoaFisicas(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<PessoaFisica> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(PessoaFisica);

            // TODO: Save the patched entity.

            // return Updated(PessoaFisica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/PessoaFisicas
        public async Task<IHttpActionResult> Post(PessoaFisica PessoaFisica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(PessoaFisica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/PessoaFisicas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<PessoaFisica> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(PessoaFisica);

            // TODO: Save the patched entity.

            // return Updated(PessoaFisica);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/PessoaFisicas(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}