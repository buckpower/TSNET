using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Repos
{
    public class ClientRepo : CarServiceRepository<Client, int>, IQueryable<Client,Client>
    {
        public override void Add(Client entity)
        {
            using (var context = new Model1Container())
            {
                context.Clients.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Delete(Client entity)
        {
            using (var context = new Model1Container())
            {
                context.Clients.Remove(entity);
                context.SaveChanges();
            }
        }

        public override Client Get(int id)
        {
            using (var context = new Model1Container())
            {
                var found = context.Clients.FirstOrDefault(x => x.Id == id);
                return found;
            }
        }

        public override ICollection<Client> GetAll()
        {
            using (var context = new Model1Container())
            {
                var foundList = context.Clients;
                return foundList.ToList();
            }
        }

        public override void Insert(Client entity)
        {
            using (var context = new Model1Container())
            {
                context.Clients.Add(entity);
                context.SaveChanges();
            }
        }

        public override void Update(Client entity)
        {
            using (var context = new Model1Container())
            {
                context.Clients.AddOrUpdate(entity);
                context.SaveChanges();
            }
        }

        public ICollection<Client> Query(Client queryParams)
        {
            using (var context = new Model1Container())
            {
                var dbList = context.Clients.AsQueryable();
                if (!string.IsNullOrEmpty(queryParams.Adresa))
                {
                    dbList = dbList.Where(x => x.Adresa == queryParams.Adresa);
                }

                if (!string.IsNullOrEmpty(queryParams.Email))
                {
                    dbList = dbList.Where(x => x.Email == queryParams.Email);
                }

                if (!string.IsNullOrEmpty(queryParams.Judet))
                {
                    dbList = dbList.Where(x => x.Judet == queryParams.Judet);
                }

                if (!string.IsNullOrEmpty(queryParams.Localitate))
                {
                    dbList = dbList.Where(x => x.Localitate == queryParams.Localitate);
                }

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