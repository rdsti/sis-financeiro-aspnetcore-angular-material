using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace controle_financeiro_bll.Models
{
    public class Usuario : IdentityRole<string>
    {
        public string CPF { get; set; }

        public string Profissao { get; set; }

        public byte[] Foto { get; set; }

        public virtual ICollection<Cartao> Cartoes { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }

    }
}
