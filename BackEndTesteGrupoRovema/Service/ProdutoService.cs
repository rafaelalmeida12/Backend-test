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
    public class ProdutoService : IProdutoInterface
    {
        private Context context = new Context();

        public List<Produto> GetProdutos()
        {
            return context.Produtos.ToList();
        }
        public Produto GetProduto(int id)
        {
            return context.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool SaveProduto(Produto produto)
        {

            try
            {
                context.Produtos.Add(produto);
                context.SaveChanges();      
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateProduto(int id, Produto p)
        {
            try
            {
                context.Entry(p).State = EntityState.Modified;
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