using System;
using System.Collections.Generic;
using System.Text;

namespace controle_financeiro_bll.Models
{
    class tipo
    {
        public int TipoId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Categoria> GetCategorias { get; set; }

    }
}
