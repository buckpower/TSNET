using System.Collections.Generic;
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
                return found;
            }
        }

        public ICollection<Auto> GetByClient(int clientId)
        {
            using (var context = new Model1Container())
            {
                var found = context.Autoes.Where(x => x.Client.Id == clientId);
                return found.ToList();
            }
        }

        public override ICollection<Auto> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Autoes;
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