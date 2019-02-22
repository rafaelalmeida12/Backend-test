using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEndTesteGrupoRovema.Models;
using BackEndTesteGrupoRovema.Contexto;
using System.Web.Http;
using System.Data.Entity;

namespace BackEndTesteGrupoRovema.Service
{
    [RoutePrefix("api/Produto")]
    public class ProdutoService : IProdutoInterface
    {
        private Context context = new Context();

        public IEnumerable<Produto> GetProdutos()
        {
            return context.Produtos.ToList();
        }

        [Route("")]
        public Produto GetProduto(int id)
        {
            return context.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public Produto GetByNome(string nome)
        {
            
            return context.Produtos.Where(p => p.Nome.Contains(nome)).First();
        }



        public bool SaveProduto(Produto p, Categoria categoria)
        {
            try
            {
                // Foreach para assim o entity verificar a Categoria já existe no banco e não fazer uma nova inserção
                foreach (Categoria c in p.Categorias)
                {
                    context.Categorias.Attach(c);
                }
                context.Produtos.Add(p);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateProduto(int Prodid, Produto p)
        {
            try
            {
                context.Entry(p).State = EntityState.Modified;
                context.Entry(p.Categorias).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteProduto(int id)
        {
            var produto = context.Produtos.Where(x => x.Id == id).FirstOrDefault();
            if (produto == null)
            {
                return false;
            }
            else
            {
                context.Entry(produto).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }
    }
}