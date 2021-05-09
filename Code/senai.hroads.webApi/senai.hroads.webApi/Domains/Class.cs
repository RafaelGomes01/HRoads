using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class Class
    {
        public Class()
        {
            Personagens = new HashSet<Personagem>();
        }

        public int IdClasse { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Personagem> Personagens { get; set; }
    }
}
