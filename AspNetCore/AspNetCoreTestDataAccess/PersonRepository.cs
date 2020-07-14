using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTestDataAccess
{
    public class PersonRepository
    {
        public async Task AddAsync(Person person)
        {
            using (var db = new PersonDbContext())
            {
                await db.People.AddAsync(person);
                await db.SaveChangesAsync();
            }
        }
        public List<Person> GetByNameAsync(String name)
        {
            using (var db = new PersonDbContext())
            {
                return db.People.Where(x => x.Name == name).ToList();
            }
        }
    }
}
