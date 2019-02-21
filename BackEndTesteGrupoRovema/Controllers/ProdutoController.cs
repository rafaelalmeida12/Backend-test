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
   public class ProdutoController : ApiController
    {
        private  IProdutoInterface produtoService = new ProdutoService();
        
        public IEnumerable<Produto> Get()
        {
            return produtoService.GetProdutos();
        }

        public IHttpActionResult Get(int id)
        {
            var getProduto = produtoService.GetProduto(id);
            if (getProduto == null)
            {
                return NotFound();
            }
            return Ok(getProduto);           
        }

        public IHttpActionResult Post([FromBody]Produto produto)
         {
            Categoria c = new Categoria();
            var saveProduto = produtoService.SaveProduto(produto,c);
            if (saveProduto == true)
            {
                return Ok();
            }
                return BadRequest();
        }

        public IHttpActionResult Put([FromBody] Produto p)
        {
            var updateProduto = produtoService.UpdateProduto(p.Id,p);
            if (updateProduto == true)
            {
                return Ok();
            }
            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            var deleteProduto = produtoService.DeleteProduto(id);
            if (deleteProduto == true)
            {
                return Ok();
            }
            return BadRequest();
        }

   }
}
