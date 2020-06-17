﻿using ContosoDDD.Aplicacao.Interfaces;
using ContosoDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoDDD.Aplicacao.Servicos
{
    public abstract class BaseServicoAplicacao<T> : IDisposable, IBaseServicoAplicacao<T> where T : class
    {

        private readonly IBaseServicoDominio<T> _servicoDominio;

        public BaseServicoAplicacao( IBaseServicoDominio<T> servicoDominio)
        {
            _servicoDominio = servicoDominio;
        }


        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public T DetalharId(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
