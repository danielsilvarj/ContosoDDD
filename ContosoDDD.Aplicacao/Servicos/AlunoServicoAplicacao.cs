using ContosoDDD.Aplicacao.Interfaces;
using ContosoDDD.Dominio.Entidade;
using ContosoDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ContosoDDD.Aplicacao.Servicos
{
    public class AlunoServicoAplicacao : BaseServicoAplicacao<Aluno>, IAlunoServicoAplicacao
    {

        public readonly IAlunoServicoDominio _alunoServicoDominio;

        public AlunoServicoAplicacao(IAlunoServicoDominio alunoServicoDominio) 
            : base(alunoServicoDominio)
        {
            _alunoServicoDominio = alunoServicoDominio;
        }

        public Aluno DetalharPorNome(string busca)
        {
            return _alunoServicoDominio.DetalharPorNome(busca);
        }

        public IEnumerable<Aluno> ListarAlunosAtivos()
        {
            return _alunoServicoDominio.ListarAlunosAtivos();
        }
    }
}
