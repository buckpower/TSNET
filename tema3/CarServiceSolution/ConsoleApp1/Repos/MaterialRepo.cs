using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ConsoleApp1.Repos
{
    public class MaterialRepo : CarServiceRepository<Material, int>, IQueryable<Material, Material>
    {
        public override void Add(Material entity)
        {
            using (var context = new Model1Container())
            {
                context.Materials.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Material entity)
        {
            using (var context = new Model1Container())
            {
                context.Materials.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Material Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Materials.FirstOrDefault(x => x.MaterialId == id);
                return found;
            }
        }

        public override ICollection<Material> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Materials;
                return foundList.ToList();
            }
        }

        public override void Insert(Material entity)
        {
            using (var context = new Model1Container())
            {
                context.Materials.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Material entity)
        {
            using (var context = new Model1Container())
            {
                context.Materials.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Material> Query(Material queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Materials.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Denumire))
                {
                    dbList = dbList.Where(x => x.Denumire == queryParams.Denumire);
                }

                if (queryParams.DataAprovizionare != null)
                {
                    dbList = dbList.Where(x => x.DataAprovizionare == queryParams.DataAprovizionare);
                }

                return dbList.ToList();
            }
        }
    }
}