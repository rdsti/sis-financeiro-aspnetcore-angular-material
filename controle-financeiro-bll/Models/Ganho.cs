using System;
using System.Collections.Generic;
using System.Text;

namespace controle_financeiro_bll.Models
{
    public class Ganho
    {
        public int GanhoId { get; set; }

        public string Descricao { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public int Dia { get; set; }

        public int MesId { get; set; }
        public Mes Mes { get; set; }

        public int AnoId { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }

}
