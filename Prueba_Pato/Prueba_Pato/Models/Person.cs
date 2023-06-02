namespace Prueba_Pato.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int idPerson, string name, string lastName, int age)
        {
            Id = idPerson;
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
