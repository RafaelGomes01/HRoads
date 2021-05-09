using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface ITipoDeHabilidadeRepository
    {
        void Create(TipoDeHabilidade novoTipoHabilidade);
        List<TipoDeHabilidade> Read();
        TipoDeHabilidade ReadById(int id);
        void Update(int id, TipoDeHabilidade tipoHabilidadeAtualizado);
        void Delete(int id);
    }
}
