using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class TipoDeHabilidadeRepository : ITipoDeHabilidadeRepository
    {
        HRoadsContext ctx = new HRoadsContext();

        public void Create(TipoDeHabilidade novoTipoHabilidade)
        {
            ctx.TiposDeHabilidades.Add(novoTipoHabilidade);
            ctx.SaveChanges();
        }

        public List<TipoDeHabilidade> Read()
        {
            return ctx.TiposDeHabilidades.ToList();
        }

        public TipoDeHabilidade ReadById(int id)
        {
            return ctx.TiposDeHabilidades.FirstOrDefault(e => e.IdTipoHabilidade == id);
        }

        public void Update(int id, TipoDeHabilidade tipoHabilidadeAtualizado)
        {
            TipoDeHabilidade tipoDeHabilidadeBuscado = ctx.TiposDeHabilidades.Find(id);

            if (tipoDeHabilidadeBuscado.Nome != null)
            {
                tipoDeHabilidadeBuscado.Nome = tipoHabilidadeAtualizado.Nome;
            }

            ctx.Update(tipoDeHabilidadeBuscado);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            TipoDeHabilidade tipoDeHabilidadeBuscado = ctx.TiposDeHabilidades.Find(id);
            ctx.TiposDeHabilidades.Remove(tipoDeHabilidadeBuscado);
            ctx.SaveChanges();
        }
    }
}
