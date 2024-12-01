using ClassLibrary1;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(Math.Round(classofliblary.z_func1(1, 2, 3), 2), Math.Round(9.245614035, 2));
            ;
        }
        [TestMethod]
        public void TestMethod2()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(Math.Round(classofliblary.z_func2(5, 2, 4), 2), Math.Round(28.84761905, 2));
        }

    }
}
