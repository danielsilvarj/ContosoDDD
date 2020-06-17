using ContosoDDD.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Dominio.Interfaces.Repositorios
{
    public interface IAlunoRepositorio : IBaseRepositorio<Aluno>
    {
        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
    }
}
