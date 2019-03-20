using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CarService.Repos
{
    public class SasiuRepo : CarServiceRepository<Sasiu, int>, IQueryable<Sasiu, Sasiu>
    {
        public override void Add(Sasiu entity)
        {
            using (var context = new Model1Container())
            {
                context.Sasius.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Sasiu entity)
        {
            using (var context = new Model1Container())
            {
                context.Sasius.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Sasiu Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Sasius.FirstOrDefault(x => x.SasiuId == id);
                return found;
            }
        }

        public override ICollection<Sasiu> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Sasius;
                return foundList.ToList();
            }
        }

        public override void Insert(Sasiu entity)
        {
            using (var context = new Model1Container())
            {
                context.Sasius.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Sasiu entity)
        {
            using (var context = new Model1Container())
            {
                context.Sasius.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Sasiu> Query(Sasiu queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Sasius.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.CodSasiu))
                {
                    dbList = dbList.Where(x => x.CodSasiu == queryParams.CodSasiu);
                }

                if (!string.IsNullOrEmpty(queryParams.Denumire))
                {
                    dbList = dbList.Where(x => x.Denumire == queryParams.Denumire);
                }

                return dbList.ToList();
            }
        }
    }
}