﻿using controle_financeiro_bll.Models;
using controle_financeiro_dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_financeiro_dal.Repositorios
{
    public class CategoriaRepositorio : RepositorioGenerico<Categoria>, ICategoriaRepositorio
    {
        private readonly Contexto _contexto;

        public CategoriaRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Categoria> PegarTodos()
        {
            try
            {
                return _contexto.Categorias.Include(c => c.Tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public new async Task<Categoria> PegarPeloId(int id)
        {
            try
            {
                var entity = await _contexto.Categorias.Include(c => c.Tipo).FirstOrDefaultAsync(c => c.CategoriaId == id);

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
