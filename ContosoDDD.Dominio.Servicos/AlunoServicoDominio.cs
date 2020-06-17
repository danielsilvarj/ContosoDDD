using ContosoDDD.Dominio.Entidade;
using ContosoDDD.Dominio.Interfaces.Repositorios;
using ContosoDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Dominio.Servicos
{
    public class AlunoServicoDominio : BaseServicoDominio<Aluno>, IAlunoServicoDominio
    {

        public readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoServicoDominio(IAlunoRepositorio alunoRepositorio)
            :base(alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno DetalharPorNome(string busca)
        {
            return _alunoRepositorio.DetalharPorNome(busca);
        }

        public IEnumerable<Aluno> ListarAlunosAtivos()
        {
         
            return _alunoRepositorio.ListarAlunosAtivos();
        }
    }
}
