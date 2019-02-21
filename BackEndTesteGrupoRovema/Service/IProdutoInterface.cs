using BackEndTesteGrupoRovema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTesteGrupoRovema.Service
{
    public interface IProdutoInterface
    {

        IEnumerable<Produto> GetProdutos();
        Produto GetProduto(int id);
        bool SaveProduto(Produto p, Categoria categoria);
        bool UpdateProduto(int id, Produto p);
        bool DeleteProduto(int id);
        Produto GetByNome(string nome);
       

    }
}
