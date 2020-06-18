using ContosoDDD.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Aplicacao.Interfaces
{
    public interface IAlunoServicoAplicacao : IBaseServicoAplicacao<Aluno>
    {
        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
    }
}
