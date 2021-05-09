using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Personagem novoPersonagem)
        {
            ctx.Personagens.Add(novoPersonagem);
            ctx.SaveChanges();
        }

        public List<Personagem> Read()
        {
            return ctx.Personagens.ToList();
        }

        public Personagem ReadById(int id)
        {
            return ctx.Personagens.FirstOrDefault(e => e.IdPersonagem == id);
        }

        public void Update(int id, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(id);

            if (personagemBuscado.IdClasse != null)
            {
                personagemBuscado.IdClasse = personagemAtualizado.IdClasse;
                personagemBuscado.Nome = personagemAtualizado.Nome;
                personagemBuscado.MaxVida = personagemAtualizado.MaxVida;
                personagemBuscado.MaxMana = personagemAtualizado.MaxMana;
                personagemBuscado.DataAtualizacao = personagemAtualizado.DataAtualizacao;
                personagemBuscado.DataCriacao = personagemAtualizado.DataCriacao;
            }

            ctx.Update(personagemBuscado);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(id);
            ctx.Personagens.Remove(personagemBuscado);
            ctx.SaveChanges();
        }
    }
}
