using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {

        HRoadsContext ctx = new HRoadsContext();

        public void Create(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);
            ctx.SaveChanges();
        }

        public List<Habilidade> Read()
        {
            return ctx.Habilidades.ToList();
        }

        public Habilidade ReadById(int id)
        {
            return ctx.Habilidades.FirstOrDefault(e => e.IdHabilidade == id);
        }

        public void Update(int id, Habilidade habilidadeAtualizado)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);
            if(habilidadeBuscada.IdTipoDeHabilidade != null)
            {
                habilidadeBuscada.IdTipoDeHabilidade = habilidadeAtualizado.IdTipoDeHabilidade;
                habilidadeBuscada.Nome = habilidadeAtualizado.Nome;
            }

            ctx.Update(habilidadeBuscada);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);
            ctx.Habilidades.Remove(habilidadeBuscada);
            ctx.SaveChanges();
        }
    }
}
