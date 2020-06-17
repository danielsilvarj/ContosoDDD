using ContosoDDD.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Dominio.Interfaces.Repositorios
{
    public interface ICursoRepositorio : IBaseRepositorio<Curso>
    {
        // IEnumerable<Curso> ListarCursosAtivos();
    }
}
