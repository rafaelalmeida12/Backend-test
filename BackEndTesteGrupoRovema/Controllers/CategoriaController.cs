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
    public class CategoriaController : ApiController
    {
        private CategoriaService categoriaService = new CategoriaService();

        public IEnumerable<Categoria> Get()
        {
            return categoriaService.GetCategorias();

        }

        public IHttpActionResult Get(int id)
        {
            var getCategoria = categoriaService.GetById(id);
            if (getCategoria == null)
            {
                return NotFound();
            }
            return Ok(getCategoria);
        }

        public IHttpActionResult Post(Categoria c)
        {
            var save = categoriaService.SaveCategoria(c);
            return Ok();

        }

        public IHttpActionResult Put(Categoria c)
        {
            var update = categoriaService.UpdateCategoria(c, c.Id);
            if (update == true)
            {
                return Ok();
            }
            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            var delete = categoriaService.Delete(id);
            if (delete == true)
            {
                return Ok();
            }
            return BadRequest();
        }



    }
}
