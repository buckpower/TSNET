using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ConsoleApp1.Repos
{
    public class DetaliuComandaRepo : CarServiceRepository<DetaliuComanda, int>, IQueryable<DetaliuComanda, DetaliuComanda>
    {
        public override void Add(DetaliuComanda entity)
        {
            using (var context = new Model1Container())
            {
                context.DetaliuComandas.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(DetaliuComanda entity)
        {
            using (var context = new Model1Container())
            {
                context.DetaliuComandas.Remove(entity);
                context.SaveChanges();
            }
        }

        public override DetaliuComanda Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.DetaliuComandas.FirstOrDefault(x => x.Id == id);
                return found;
            }
        }

        public override ICollection<DetaliuComanda> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.DetaliuComandas;
                return foundList.ToList();
            }
        }

        public override void Insert(DetaliuComanda entity)
        {
            using (var context = new Model1Container())
            {
                context.DetaliuComandas.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(DetaliuComanda entity)
        {
            using (var context = new Model1Container())
            {
                context.DetaliuComandas.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<DetaliuComanda> Query(DetaliuComanda queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.DetaliuComandas.AsQueryable();

                return dbList.ToList();
            }
        }
    }
}