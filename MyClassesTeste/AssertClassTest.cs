using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTeste
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests
        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreEqualTest()
        {
            string str1 = "Axel";
            string str2 = "Axel";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Axel";
            string str2 = "axel";

            Assert.AreEqual(str1, str2, false);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreNotEqualTest()
        {
            string str1 = "Axel";
            string str2 = "AxelGeorg";

            Assert.AreNotEqual(str1, str2);
        }
        #endregion

        #region AreSame/AreNotSame Tests
        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }
        #endregion

        #region IsInstanceOfType Test
        [TestMethod]
        [Owner("AxelGeorg")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager manager = new PersonManager();
            Person person;

            person = manager.CreatePerson("Axel", "Georg", true);

            Assert.IsInstanceOfType(person, typeof(Supervisor));
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void IsNullTest()
        {
            PersonManager manager = new PersonManager();
            Person person;

            person = manager.CreatePerson("", "Georg", true);

            Assert.IsNull(person);
        }
        #endregion
    }
}
