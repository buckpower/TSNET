using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CarService.Repos
{
    public class OperatieRepo : CarServiceRepository<Operatie, int>, IQueryable<Operatie, Operatie>
    {
        public override void Add(Operatie entity)
        {
            using (var context = new Model1Container())
            {
                context.Operaties.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Operatie entity)
        {
            using (var context = new Model1Container())
            {
                context.Operaties.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Operatie Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Operaties.FirstOrDefault(x => x.OperatieId == id);
                return found;
            }
        }

        public override ICollection<Operatie> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Operaties;
                return foundList.ToList();
            }
        }

        public override void Insert(Operatie entity)
        {
            using (var context = new Model1Container())
            {
                context.Operaties.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Operatie entity)
        {
            using (var context = new Model1Container())
            {
                context.Operaties.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Operatie> Query(Operatie queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Operaties.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Denumire))
                {
                    dbList = dbList.Where(x => x.Denumire == queryParams.Denumire);
                }

                return dbList.ToList();
            }
        }
    }
}