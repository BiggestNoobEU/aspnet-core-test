using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AspNetCoreTestDataAccess.Test
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public async Task AddNewPerson_ReturnsOk()
        {
            var repository = new PersonRepository();

            var person = new Person()
            {
                Name = "TestName",
                Surname = "TestSurname",
                Address = new Address
                {
                    StreetName = "TestStreetName",
                    StreetNr = 98
                },
                Age = 100,
                Email = "test@email.com",
                IsMale = true
            }; // person.Name = "TestName" is the long way

            await repository.AddAsync(person);
        }



        [TestMethod]
        public void GetPerson_ReturnsPerson()
        {
            var repository = new PersonRepository();
            
            var result = repository.GetByNameAsync("TestName");
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void GetNoPerson_ReturnsPerson()
        {
            var repository = new PersonRepository();

            var result = repository.GetByNameAsync("Jambulaja");
            Assert.AreEqual(0, result.Count);
        }
    }
}
