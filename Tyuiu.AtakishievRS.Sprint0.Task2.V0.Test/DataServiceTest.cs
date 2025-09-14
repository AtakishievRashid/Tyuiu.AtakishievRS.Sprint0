using Tyuiu.AtakishievRS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AtakishievRS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Рашид";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Рашид", res);
        }
    }
}
