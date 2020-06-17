using ContosoDDD.Aplicacao.Interfaces;
using ContosoDDD.Dominio.Entidade;
using ContosoDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Aplicacao.Servicos
{
    public class AlunoServicoAplicacao : BaseServicoAplicacao<Aluno>, IAlunoServicoAplicacao
    {
        public AlunoServicoAplicacao(IBaseServicoDominio<Aluno> servicoDominio) : base(servicoDominio)
        {

        }
    }
}
