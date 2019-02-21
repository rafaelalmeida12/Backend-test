using BackEndTesteGrupoRovema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTesteGrupoRovema.Service
{
    public interface ICategoriaInterface
    {
        
        bool SaveCategoria(Categoria c);
        bool UpdateCategoria(Categoria c, int id);
        IEnumerable<Categoria> GetCategorias();
        Categoria GetById(int id);
        bool Delete(int id);
        IEnumerable<Categoria> GetByNome(string nome);
    }
}
