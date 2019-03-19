using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ConsoleApp1.Repos
{
    public class ImagineRepo : CarServiceRepository<Imagine, int>, IQueryable<Imagine, Imagine>
    {
        public override void Add(Imagine entity)
        {
            using (var context = new Model1Container())
            {
                context.Imagines.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Imagine entity)
        {
            using (var context = new Model1Container())
            {
                context.Imagines.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Imagine Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Imagines.FirstOrDefault(x => x.ImagineId == id);
                return found;
            }
        }

        public override ICollection<Imagine> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Imagines;
                return foundList.ToList();
            }
        }

        public override void Insert(Imagine entity)
        {
            using (var context = new Model1Container())
            {
                context.Imagines.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Imagine entity)
        {
            using (var context = new Model1Container())
            {
                context.Imagines.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Imagine> Query(Imagine queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Imagines.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Descriere))
                {
                    dbList = dbList.Where(x => x.Descriere == queryParams.Descriere);
                }

                if (!string.IsNullOrEmpty(queryParams.Titlu))
                {
                    dbList = dbList.Where(x => x.Titlu == queryParams.Titlu);
                }

                if (queryParams.Data != null)
                {
                    dbList = dbList.Where(x => x.Data == queryParams.Data);
                }

                if (queryParams.Foto != null)
                {
                    dbList = dbList.Where(x => x.Foto == queryParams.Foto);
                }

                return dbList.ToList();
            }
        }
    }
}