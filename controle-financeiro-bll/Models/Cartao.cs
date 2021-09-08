using System;
using System.Collections.Generic;
using System.Text;

namespace controle_financeiro_bll.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }

        public string Nome { get; set; }

        public string Bandeira { get; set; }

        public double Limite { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }

    }
}
