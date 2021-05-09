using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public List<Usuario> Read()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario ReadById(int id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Update(int id, Usuario UsuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            if (usuarioBuscado.Email != null)
            {
                usuarioBuscado.Email = UsuarioAtualizado.Email;
                usuarioBuscado.Senha = UsuarioAtualizado.Senha;
                usuarioBuscado.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
            }

            ctx.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);
            ctx.Usuarios.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            Usuario usuarioBuscado = ctx.Usuarios.FirstOrDefault(e => e.Email == email && e.Senha == senha);

            if(usuarioBuscado != null)
            {
                return usuarioBuscado;
            }

            return null;
        }
    }
}
