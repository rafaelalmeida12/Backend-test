using BackEndTesteGrupoRovema.Contexto;
using BackEndTesteGrupoRovema.Models;
using BackEndTesteGrupoRovema.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndTesteGrupoRovema.Controllers
{
    [RoutePrefix("api/Categoria")]
    public class CategoriaController : ApiController
    {
        private CategoriaService categoriaService = new CategoriaService();

        public IEnumerable<Categoria> Get()
        {
            return categoriaService.GetCategorias();

        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var getCategoria = categoriaService.GetById(id);
            if (getCategoria == null)
            {
                return Content(HttpStatusCode.NotFound, "Resource not found");
            }
            return Ok(getCategoria);
        }


        [Route("{nome}")]
        public IHttpActionResult GetByNome(string nome)
        {
            var getCategoria = categoriaService.GetByNome(nome);
            if (getCategoria == null)
            {
                return Content(HttpStatusCode.NotFound, "Resource not found");
            }
            return Ok(getCategoria);
        }

        public IHttpActionResult Post(Categoria c)
        {
            var save = categoriaService.SaveCategoria(c);
            return Content(HttpStatusCode.OK, "Successful");

        }

        public IHttpActionResult Put(Categoria c)
        {
            var update = categoriaService.UpdateCategoria(c, c.Id);
            if (update == true)
            {
                return Content(HttpStatusCode.OK, "Successful");
            }
            return Content(HttpStatusCode.BadRequest, "Bad input parameter");
        }

        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var delete = categoriaService.Delete(id);
            if (delete == true)
            {
                return Content(HttpStatusCode.OK, "Successful");
            }
            return Content(HttpStatusCode.BadRequest, "Bad input parameter");
        }



    }
}
