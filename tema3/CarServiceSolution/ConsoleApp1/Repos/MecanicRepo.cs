using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CarService.Repos
{
    public class MecanicRepo : CarServiceRepository<Mecanic, int>, IQueryable<Mecanic, Mecanic>
    {
        public override void Add(Mecanic entity)
        {
            using (var context = new Model1Container())
            {
                context.Mecanics.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Mecanic entity)
        {
            using (var context = new Model1Container())
            {
                context.Mecanics.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Mecanic Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Mecanics.FirstOrDefault(x => x.MecanicId == id);
                return found;
            }
        }

        public override ICollection<Mecanic> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Mecanics;
                return foundList.ToList();
            }
        }

        public override void Insert(Mecanic entity)
        {
            using (var context = new Model1Container())
            {
                context.Mecanics.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Mecanic entity)
        {
            using (var context = new Model1Container())
            {
                context.Mecanics.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Mecanic> Query(Mecanic queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Mecanics.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Nume))
                {
                    dbList = dbList.Where(x => x.Nume == queryParams.Nume);
                }

                if (!string.IsNullOrEmpty(queryParams.Prenume))
                {
                    dbList = dbList.Where(x => x.Prenume == queryParams.Prenume);
                }

                return dbList.ToList();
            }
        }
    }
}