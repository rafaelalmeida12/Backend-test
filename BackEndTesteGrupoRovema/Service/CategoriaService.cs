using System;
using System.Collections.Generic;
using System.Linq;
using BackEndTesteGrupoRovema.Contexto;
using System.Web;
using BackEndTesteGrupoRovema.Models;
using System.Data.Entity;

namespace BackEndTesteGrupoRovema.Service
{
    public class CategoriaService : ICategoriaInterface
    {
        private Context context = new Context();

        public bool Delete(int id)
        {
            try
            {
                Categoria c = context.Categorias.Find(id);//Buscar o Id passado como parâmetro no Banco
                List<Produto> produtos = c.Produtos.ToList();//Busca os produtos relacionados com o Id passado como parâmetro
                produtos.ForEach(p => c.Produtos.Remove(p));//Remove as categorias dos produtos
                context.Categorias.Remove(c);//remove categorias
                context.SaveChanges();
                return true;
            }
        }

        public Categoria GetById(int id)
        {
            return context.Categorias.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Categoria> GetByNome(string nome)
        {
            return context.Categorias.Where(c => c.Nome.Contains(nome));
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return context.Categorias.ToList();
        }

        public bool SaveCategoria(Categoria c)
        {
            try
            {
                context.Categorias.Add(c);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateCategoria(Categoria c, int id)
        {
            try
            {
                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}