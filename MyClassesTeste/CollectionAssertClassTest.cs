using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System.Collections.Generic;

namespace MyClassesTeste
{
    [TestClass]
    public class CollectionAssertClassTest
    {
        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreCollectionEqualFailBecauseNoComparerTest()
        {
            PersonManager manager = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FisrtName = "Axel", LastName = "Georg" });
            peopleExpected.Add(new Person() { FisrtName = "Amanda", LastName = "Eloisa" });
            peopleExpected.Add(new Person() { FisrtName = "Marli", LastName = "Carmen" });

            // You shall not pass!
            peopleActual = manager.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreCollectionEqualWithComparerTest()
        {
            PersonManager manager = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FisrtName = "Axel", LastName = "Georg" });
            peopleExpected.Add(new Person() { FisrtName = "Amanda", LastName = "Eloisa" });
            peopleExpected.Add(new Person() { FisrtName = "Marli", LastName = "Carmen" });

            // You shall not pass!
            peopleActual = manager.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual, Comparer<Person>.Create((x, y) => x.FisrtName == y.FisrtName && x.LastName == y.LastName ? 0 : 1));
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreCollectionEquivalentTest()
        {
            PersonManager manager = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = manager.GetPeople();

            //ordem diferente
            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void IsCollectionOfTypeTest()
        {
            PersonManager manager = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = manager.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
