using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HRoadsContext ctx = new HRoadsContext();

        public void Create(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(novoTipoUsuario);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Read()
        {
            return ctx.TipoUsuarios.ToList();
        }

        public TipoUsuario ReadById(int id)
        {
            return ctx.TipoUsuarios.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Update(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoUsuarioBuscado = ctx.TipoUsuarios.Find(id);

            if (tipoUsuarioBuscado.TipoUsuario1 != null)
            {
                tipoUsuarioBuscado.TipoUsuario1 = tipoUsuarioAtualizado.TipoUsuario1;
            }

            ctx.Update(tipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            TipoUsuario tipoUsuarioBuscado = ctx.TipoUsuarios.Find(id);
            ctx.TipoUsuarios.Remove(tipoUsuarioBuscado);
            ctx.SaveChanges();
        }

    }
}
