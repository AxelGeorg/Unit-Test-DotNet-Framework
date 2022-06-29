using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string firstName, string lastName, bool isSupervisor)
        {
            Person person = null;

            if (!string.IsNullOrEmpty(firstName))
            {
                if (isSupervisor)
                    person = new Supervisor();
                else
                    person = new Employee();

                person.FisrtName = firstName;
                person.LastName = lastName;
            }

            return person;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FisrtName = "Axel", LastName = "Georg" });
            people.Add(new Person() { FisrtName = "Amanda", LastName = "Eloisa" });
            people.Add(new Person() { FisrtName = "Marli", LastName = "Carmen" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Axel", "Georg", true));
            people.Add(CreatePerson("Amanda", "Eloisa", true));
            people.Add(CreatePerson("Marli", "Carmen", true));

            return people;
        }
    }
}
