using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ConsoleApp1.Repos
{
    public class ComandaRepo : CarServiceRepository<Comanda, int>, IQueryable<Comanda, Comanda>
    {
        public override void Add(Comanda entity)
        {
            using (var context = new Model1Container())
            {
                context.Comandas.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Comanda entity)
        {
            using (var context = new Model1Container())
            {
                context.Comandas.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Comanda Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Comandas.FirstOrDefault(x => x.ComandaID == id);
                return found;
            }
        }

        public override ICollection<Comanda> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Comandas;
                return foundList.ToList();
            }
        }

        public override void Insert(Comanda entity)
        {
            using (var context = new Model1Container())
            {
                context.Comandas.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Comanda entity)
        {
            using (var context = new Model1Container())
            {
                context.Comandas.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Comanda> Query(Comanda queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Comandas.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Descriere))
                {
                    dbList = dbList.Where(x => x.Descriere == queryParams.Descriere);
                }

                if (queryParams.DAtaSystem!= null)
                {
                    dbList = dbList.Where(x => x.DAtaSystem == queryParams.DAtaSystem);
                }

                if (queryParams.DataProgramare != null)
                {
                    dbList = dbList.Where(x => x.DataProgramare == queryParams.DataProgramare);
                }

                return dbList.ToList();
            }
        }
    }
}