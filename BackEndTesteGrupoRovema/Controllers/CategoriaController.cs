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
        private CategoriaService cService = new CategoriaService();

        public IList<Categoria> Get()
        {
            return cService.GetCategorias();

        }

        public IHttpActionResult Get(int id)
        {
            var getCategoria = cService.GetById(id);
            if (getCategoria == null)
            {
                return NotFound();
            }
            return Ok(getCategoria);
        }

        public IHttpActionResult Post(Categoria c)
        {
            var save = cService.SaveCategoria(c);
            return Ok();

        }

        public IHttpActionResult Put(Categoria c)
        {
            var update = cService.UpdateCategoria(c, c.Id);
            if (update == true)
            {
                return Ok();
            }
            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            var delete = cService.Delete(id);
            if (delete == true)
            {
                return Ok();
            }
            return BadRequest();
        }



    }
}
