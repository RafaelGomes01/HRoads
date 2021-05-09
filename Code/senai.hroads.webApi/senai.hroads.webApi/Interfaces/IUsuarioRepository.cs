using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IUsuarioRepository
    {
        void Create(Usuario novoUsuario);
        List<Usuario> Read();
        Usuario ReadById(int id);
        void Update(int id, Usuario UsuarioAtualizado);
        void Delete(int id);
        Usuario Login(string email, string senha);
    }
}
