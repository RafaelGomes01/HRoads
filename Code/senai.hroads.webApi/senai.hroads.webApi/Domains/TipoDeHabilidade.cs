using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class TipoDeHabilidade
    {
        public TipoDeHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHabilidade { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
