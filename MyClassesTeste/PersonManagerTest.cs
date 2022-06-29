using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System.Collections.Generic;

namespace MyClassesTeste
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        [Owner("AxelGeorg")]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            PersonManager manager = new PersonManager();
            Person person;

            person = manager.CreatePerson("Axel", "Georg", false);

            Assert.IsInstanceOfType(person, typeof(Employee));
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void DoEmployeeExistTest()
        {
            Supervisor supervisor = new Supervisor();

            supervisor.Employees = new List<Employee>();
            supervisor.Employees.Add(new Employee()
            {
                FisrtName = "Axel",
                LastName = "Georg"
            });

            Assert.IsTrue(supervisor.Employees.Count > 0);
        }
    }
}
