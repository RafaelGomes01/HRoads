using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface ITipoUsuarioRepository
    {
        void Create(TipoUsuario novoTipoUsuario);
        List<TipoUsuario> Read();
        TipoUsuario ReadById(int id);
        void Update(int id, TipoUsuario tipoUsuarioAtualizado);
        void Delete(int id);
    }
}
