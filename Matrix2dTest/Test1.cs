using Matrix2dLib;

namespace Matrix2dTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstructor_Wieloargumentowy_Poprawnie_OK()
        {
            //Arrange
            var m = new Matrix2d(1, 2, 3, 4);

            //Act


            //Assert
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }
    }
}
