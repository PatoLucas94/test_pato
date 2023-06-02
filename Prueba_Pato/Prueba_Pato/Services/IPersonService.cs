using Prueba_Pato.Models;

namespace Prueba_Pato.Services
{
    public interface IPersonService
    {
        public List<Person> GetPersons();
        public Person GetOnePerson(int id);
        public Person CreatePerson(Person Person);

    }
}
