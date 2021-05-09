using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTipoDeHabilidade { get; set; }
        public string Nome { get; set; }

        public virtual TipoDeHabilidade IdTipoDeHabilidadeNavigation { get; set; }
    }
}
