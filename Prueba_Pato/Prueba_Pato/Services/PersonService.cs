using Prueba_Pato.Models;

namespace Prueba_Pato.Services
{
    public class PersonService : IPersonService
    {

        private readonly AplicationDbContext _context;

        public PersonService(AplicationDbContext context)
        {
            _context = context;
        }
        public List<Person> GetPersons()
        {
            return _context.Person.ToList();
        }
        public Person GetOnePerson(int id)
        {
            var personSearched = _context.Person.FirstOrDefault(x => x.Id == id);
            return personSearched;
        }

        public Person CreatePerson(Person newPerson)
        {
            _context.Person.Add(newPerson);
            return newPerson;
        }

        public Person DeletePerson(int id)
        {
            return DeletePerson(GetOnePerson(id));
        }

        public Person DeletePerson(Person person)
        {
            _context.Person.Remove(person);
            return person;
        }

       
    }
}
