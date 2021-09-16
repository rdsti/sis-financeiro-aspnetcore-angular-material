using controle_financeiro_bll.Models;
using controle_financeiro_dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace controle_financeiro_dal.Repositorios
{
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        public TipoRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
