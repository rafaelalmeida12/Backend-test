using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEndTesteGrupoRovema.Contexto;
using BackEndTesteGrupoRovema.Models;
using BackEndTesteGrupoRovema.Service;

namespace BackEndTesteGrupoRovema.Controllers
{
    [RoutePrefix("api/Produto")]
   public class ProdutoController : ApiController
    {
        private  IProdutoInterface produtoService = new ProdutoService();
        
        public IEnumerable<Produto> Get()
        {
            return produtoService.GetProdutos();
            
        }

        
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var getProduto = produtoService.GetProduto(id);
            if (getProduto == null)
            {
                return NotFound();
            }
            return Ok(getProduto);           
        }


        [Route("{nome}")]
        public IHttpActionResult GetByNome(string nome)
        {
            var getPorNome = produtoService.GetByNome(nome);
            if (getPorNome == null)
            {
                return Content(HttpStatusCode.NotFound,"Resource not found");
            }
            return Ok(getPorNome);
        }

        public IHttpActionResult Post([FromBody]Produto produto)
         {
            
            Categoria c = new Categoria();
            var saveProduto = produtoService.SaveProduto(produto,c);
            if (saveProduto == true)
            {
                return Content(HttpStatusCode.OK,"Successful");
            }
                return Content(HttpStatusCode.BadRequest,"Bad input parameter");
        }

        
        public IHttpActionResult Put([FromBody] Produto p)
        {

            
            var updateProduto = produtoService.UpdateProduto(p.Id,p);
            if (updateProduto == true)
            {
                return Content(HttpStatusCode.OK,"Successful");
            }
            return Content(HttpStatusCode.BadRequest, "Bad input parameter");

        }


        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var deleteProduto = produtoService.DeleteProduto(id);
            if (deleteProduto == true)
            {
                return Content(HttpStatusCode.OK, "Successful");
            }
            return Content(HttpStatusCode.BadRequest, "Bad input parameter");

        }

    }
}
