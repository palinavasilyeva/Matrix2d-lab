using Matrix2dLib;

namespace Matrix2dTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstructor_Wieloargumentowy_PoprawnieDane_OK()
        {
            //Arrange
            var m = new Matrix2d(1, 2, 3, 4);

            //Assert
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }

        [TestMethod]
        public void Konstruktor_BezArgumentow_PoprawneDane_OK()
        {
            //Arrange
            var m = new Matrix2d();
            // Assert
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(0, m.B);
            Assert.AreEqual(0, m.C);
            Assert.AreEqual(1, m.D);
        }

        [TestMethod]
        public void Test_Static_Id()
        {
            Assert.AreEqual(1, Matrix2d.Id.A);
            Assert.AreEqual(0, Matrix2d.Id.B);
            Assert.AreEqual(0, Matrix2d.Id.C);
            Assert.AreEqual(1, Matrix2d.Id.D);
        }
        [TestMethod]
        public void Test_Static_Zero()
        {
            Assert.AreEqual(0, Matrix2d.Zero.A);
            Assert.AreEqual(0, Matrix2d.Zero.B);
            Assert.AreEqual(0, Matrix2d.Zero.C);
            Assert.AreEqual(0, Matrix2d.Zero.D);  
        }

        [TestMethod]
        public void Test_ToString()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            Assert.AreEqual("[1, 2], [3, 4]", m.ToString());
        }

        [TestMethod]
        public void Test_Equals_True()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 4);
            Assert.IsTrue(m1.Equals(m2));
        }

        [TestMethod]
        public void Test_Equals_False()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 5);
            Assert.IsFalse(m1.Equals(m2));
        }

        [TestMethod]
        public void Test_Equals_Null()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            Matrix2d m2 = null;
            Assert.IsFalse(m1.Equals(m2));
        }

        [TestMethod]
        public void Test_Equals_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 4);
            Assert.IsTrue(m1 == m2);
        }
        
        [TestMethod]
        public void Test_NotEquals_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 4);
            Assert.IsTrue(m1 != m2);
        }

        [TestMethod]
        public void Test_Add_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 5);
            
            var result = m1 + m2;

            Assert.AreEqual(2, result.A);
            Assert.AreEqual(4, result.B);
            Assert.AreEqual(6, result.C);
            Assert.AreEqual(9, result.D);
            Assert.AreEqual(m1.A + m2.A, result.A);  
            Assert.AreEqual(m1.B + m2.B, result.B); 
            Assert.AreEqual(m1.C + m2.C, result.C); 
            Assert.AreEqual(m1.D + m2.D, result.D); 
        }
        [TestMethod]
        public void Test_Subtract_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 5);
            
            var result = m1 - m2;

            Assert.AreEqual(0, result.A);
            Assert.AreEqual(0, result.B);
            Assert.AreEqual(0, result.C);
            Assert.AreEqual(1, result.D);
            Assert.AreEqual(m1.A - m2.A, result.A);  
            Assert.AreEqual(m1.B - m2.B, result.B); 
            Assert.AreEqual(m1.C - m2.C, result.C); 
            Assert.AreEqual(m1.D - m2.D, result.D); 
        }
    }
}
