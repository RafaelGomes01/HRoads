using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IClassRepository
    {
        void Create(Class novaClass);
        List<Class> Read();
        Class ReadById(int id);
        void Update(int id, Class classAtualizada);
        void Delete(int id);
    }
}
