using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IPersonagemRepository
    {
        void Create(Personagem novoPersonagem);
        List<Personagem> Read();
        Personagem ReadById(int id);
        void Update(int id, Personagem personagemAtualizado);
        void Delete(int id);
    }
}
