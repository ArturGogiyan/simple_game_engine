using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Units;

namespace Sbt.Test.Refactoring.Tests {
    [TestClass]
    public class UnitCollectionTest {

        [TestMethod]
        public void TestShouldTurn() {
            UnitCollection collection = new UnitCollection();
            Map map = new Map(5,5);
            Units.Tractor tractor = new Units.Tractor(map, new Coordinates(2,2));
            Tank tank = new Tank(map, new Coordinates(3,3));
            DefenceTower tower = new DefenceTower(map, new Coordinates(5,5));

            collection.Add(tractor);
            collection.Add(tank);
            collection.Add(tower);

            collection.ExecuteCommand(new MoveForwardCommand());

            Assert.AreEqual((uint)2, tractor.Position.X);
            Assert.AreEqual((uint)3, tractor.Position.Y);

            Assert.AreEqual((uint)3, tank.Position.X);
            Assert.AreEqual((uint)4, tank.Position.Y);

            Assert.AreEqual((uint)5, tower.Position.X);
            Assert.AreEqual((uint)5, tower.Position.Y);
        }
    }
}
