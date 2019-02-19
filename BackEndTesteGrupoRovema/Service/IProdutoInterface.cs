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
        List<Produto> GetProdutos();
        Produto GetProduto(int id);
        bool SaveProduto(Produto produto);
        bool UpdateProduto(int id, Produto p);
        bool DeleteProduto(int id);

    }
}
