﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace controle_financeiro_dal.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {

        IQueryable<TEntity> PegarTodos();

        Task<TEntity> PegarPeloId(int id);

        Task<TEntity> PegarPeloId(string id);

        Task Inserir(TEntity entity);

        Task Inserir(List<TEntity> entity);

        Task Atualizar(TEntity entity);

        Task Excluir(string id);
        
        Task Excluir(int id);

    }

}
