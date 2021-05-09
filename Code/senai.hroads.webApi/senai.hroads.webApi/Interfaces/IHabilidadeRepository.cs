using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IHabilidadeRepository
    {
        void Create(Habilidade novaHabilidade);
        List<Habilidade> Read();
        Habilidade ReadById(int id);
        void Update(int id, Habilidade habilidadeAtualizado);
        void Delete(int id);
    }
}
