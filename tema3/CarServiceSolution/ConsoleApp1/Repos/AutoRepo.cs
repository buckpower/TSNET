using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CarService.Repos
{
    public class AutoRepo : CarServiceRepository<Auto, int>, IQueryable<Auto, Auto>
    {
        public override void Add(Auto entity)
        {
            using (var context = new Model1Container())
            {
                var client = context.Clients.First(c => c.Id == entity.Client.Id);
                entity.Client = client;
                //entity.ClientId = client.Id;
                context.Autoes.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Auto entity)
        {
            using (var context = new Model1Container())
            {
                context.Autoes.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Auto Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Autoes.FirstOrDefault(x => x.AutoId == id);
                if (found.Client == null)
                {
                    found.Client = context.Clients.SingleOrDefault(c => c.Id == found.ClientId);
                }
                //Sasiu
                if (found.Sasiu == null)
                {
                    //found.Sasiu = context.Sasius.SingleOrDefault(c => c.SasiuId == found.sa);
                }
                return found;
            }
        }

        public ICollection<Auto> GetByClient(int clientId)
        {
            using (var context = new Model1Container())
            {
                if (context.Autoes.Count() == 0)
                {
                    return new List<Auto>();
                }

                var found = context.Autoes.Where(x => x.Client.Id == clientId)
                    .Include(c => c.Client)
                    .Include(c => c.Sasiu);
                return found.ToList();
            }
        }

        public override ICollection<Auto> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Autoes.Include(c => c.Client)
                    .Include(c => c.Sasiu); ;
                return foundList.ToList();
            }
        }

        public override void Insert(Auto entity)
        {
            using (var context = new Model1Container())
            {
                context.Autoes.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Auto entity)
        {
            using (var context = new Model1Container())
            {
                context.Autoes.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Auto> Query(Auto queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Autoes.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.NumarAuto))
                {
                    dbList = dbList.Where(x => x.NumarAuto == queryParams.NumarAuto);
                }

                if (!string.IsNullOrEmpty(queryParams.SerieSasiu))
                {
                    dbList = dbList.Where(x => x.SerieSasiu == queryParams.SerieSasiu);
                }

                return dbList.ToList();
            }
        }
    }
}