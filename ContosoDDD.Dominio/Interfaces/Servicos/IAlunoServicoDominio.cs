using ContosoDDD.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Dominio.Interfaces.Servicos
{
    public interface IAlunoServicoDominio: IBaseServicoDominio<Aluno>
    {
        Aluno DetalharPorNome(string busca);
        IEnumerable<Aluno> ListarAlunosAtivos();
    }
}
