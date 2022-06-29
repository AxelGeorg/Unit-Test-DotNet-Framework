using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace MyClassesTeste
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        [Owner("AxelGeorg")]
        public void ContainsTest()
        {
            string str1 = "Axel Georg";
            string str2 = "Georg";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void StartWithTest()
        {
            string str1 = "Todos Caixa Alta";
            string str2 = "Todos Caixa";

            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void IsAllLowerCaseTest()
        {
            Regex regex = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("todos caixa", regex);
        }

        [TestMethod]
        [Owner("AxelGeorg")]
        public void IsNotAllLowerCaseTest()
        {
            Regex regex = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("Todos caixa", regex);
        }
    }
}
