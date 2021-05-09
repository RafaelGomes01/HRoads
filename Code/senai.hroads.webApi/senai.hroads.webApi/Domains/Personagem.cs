using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string Nome { get; set; }
        public byte MaxVida { get; set; }
        public byte MaxMana { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
    }
}
