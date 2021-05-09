using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class ClasseHabilidade
    {
        public int? IdHabilidade { get; set; }
        public int? IdClasse { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
