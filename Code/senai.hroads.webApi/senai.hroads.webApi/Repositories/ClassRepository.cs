using Microsoft.EntityFrameworkCore;
using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class ClassRepository : IClassRepository
    {
        HRoadsContext ctx = new HRoadsContext();

        public void Create(Class novaClass)
        {
            ctx.Add(novaClass);
            ctx.SaveChanges();
        }

        public List<Class> Read()
        {
            return ctx.Classes.ToList();
        }

        public Class ReadById(int id)
        {
            return ctx.Classes.FirstOrDefault(e => e.IdClasse == id);
        }

        public void Update(int id, Class classAtualizada)
        {
            Class classeBuscada = ctx.Classes.Find(id);

            if(classeBuscada.Nome != null)
            {
                classeBuscada.Nome = classAtualizada.Nome;
            }

            ctx.Update(classeBuscada);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Class classeBuscada = ctx.Classes.Find(id);
            ctx.Classes.Remove(classeBuscada);
            ctx.SaveChanges();
        }

    }
}
