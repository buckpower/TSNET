using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CarService.Repos
{
    public class ComandaRepo : CarServiceRepository<Comanda, int>, IQueryable<Comanda, Comanda>
    {
        public override void Add(Comanda entity)
        {
            using (var context = new Model1Container())
            {
                //entity.Client = null;
                //Get client
                var client = context.Clients.FirstOrDefault(c => c.Id == entity.Client.Id);
                var auto = context.Autoes.FirstOrDefault(a => a.AutoId == entity.Auto.AutoId);

                entity.Client = client;
                entity.Auto = auto;

                entity.DAtaSystem = entity.DAtaSystem == null ? DateTime.Now : entity.DAtaSystem;
                entity.DataProgramare = entity.DataProgramare == null ? DateTime.Now : entity.DataProgramare;

                //Get auto

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

        public ICollection<Comanda> GetByAutoId(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Comandas.Where(x => x.Auto.AutoId == id);
                return found.ToList();
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

        public ICollection<Comanda> GetByClientId(int clientId)
        {
            using (var context = new Model1Container())
            {
                var found = context.Comandas.Where(x => x.Client.Id == clientId);
                return found.ToList();
            }
        }
    }
}