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
            var m2 = new Matrix2d(1, 2, 3, 5);
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
            Assert.AreEqual(-1, result.D);
            Assert.AreEqual(m1.A - m2.A, result.A);
            Assert.AreEqual(m1.B - m2.B, result.B);
            Assert.AreEqual(m1.C - m2.C, result.C);
            Assert.AreEqual(m1.D - m2.D, result.D);
        }

        [TestMethod]
        public void Test_Multiply_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d(1, 2, 3, 5);

            var result = m1 * m2;

            Assert.AreEqual(7, result.A);
            Assert.AreEqual(12, result.B);
            Assert.AreEqual(15, result.C);
            Assert.AreEqual(26, result.D);
            Assert.AreEqual(m1.A * m2.A + m1.B * m2.C, result.A);
            Assert.AreEqual(m1.A * m2.B + m1.B * m2.D, result.B);
            Assert.AreEqual(m1.C * m2.A + m1.D * m2.C, result.C);
            Assert.AreEqual(m1.C * m2.B + m1.D * m2.D, result.D);
        }

        [TestMethod]
        public void Test_Multiply_Number_Left_Operator()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var x = 2;
            var m3 = m1 * x;
            Assert.AreEqual(2, m3.A);
            Assert.AreEqual(4, m3.B);
            Assert.AreEqual(6, m3.C);
            Assert.AreEqual(8, m3.D);
            Assert.AreEqual(m1.A * x, m3.A);
            Assert.AreEqual(m1.B * x, m3.B);
            Assert.AreEqual(m1.C * x, m3.C);
            Assert.AreEqual(m1.D * x, m3.D);
        }

        [TestMethod]
        public void Test_Multiply_Number_Right_Operatort()
        {
            var x = 2;
            var m2 = new Matrix2d(1, 2, 3, 4);
            var m3 = x * m2;
            Assert.AreEqual(2, m3.A);
            Assert.AreEqual(4, m3.B);
            Assert.AreEqual(6, m3.C);
            Assert.AreEqual(8, m3.D);
            Assert.AreEqual(x * m2.A, m3.A);
            Assert.AreEqual(x * m2.B, m3.B);
            Assert.AreEqual(x * m2.C, m3.C);
            Assert.AreEqual(x * m2.D, m3.D);
        }

        [TestMethod]
        public void Test_Operator_Negate()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = -m1;
            Assert.AreEqual(-1, m2.A);
            Assert.AreEqual(-2, m2.B);
            Assert.AreEqual(-3, m2.C);
            Assert.AreEqual(-4, m2.D);
        }

        [TestMethod]
        public void Test_Static_Transpose()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m = Matrix2d.Transpose(m1);
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(3, m.B);
            Assert.AreEqual(2, m.C);
            Assert.AreEqual(4, m.D);
        }

        [TestMethod]
        public void Test_Static_Determinant()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            var m1 = Matrix2d.Determinant(m);
            Assert.AreEqual(-2, m1);
        }

        [TestMethod]
        public void Test_Det()
        {
            var m = new Matrix2d(1, 2, 3, 4);
            Assert.AreEqual(-2, m.Det());
        }

        [TestMethod]
        public void Test_Parse()
        {
            var m = Matrix2d.Parse("[1, 2], [3, 4]");
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }
        [TestMethod]
        public void Test_Parse_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Matrix2d.Parse("[1, 2], [3]"));
        }

        [TestMethod]
        public void Test_Full_constructor()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }
        [TestMethod]
        public void Test_Empty_Constructor()
        {
            var m = new Matrix2d();

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(0, m.B);
            Assert.AreEqual(0, m.C);
            Assert.AreEqual(1, m.D);
        }

        [TestMethod]
        public void Test_Operator_Explicit_Conversion()
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = (int[,])m1;
            Assert.AreEqual(1, m2[0, 0]);
            Assert.AreEqual(2, m2[0, 1]);
            Assert.AreEqual(3, m2[1, 0]);
            Assert.AreEqual(4, m2[1, 1]);
            Assert.AreEqual(m1.A, m2[0, 0]);
            Assert.AreEqual(m1.B, m2[0, 1]);
            Assert.AreEqual(m1.C, m2[1, 0]);
            Assert.AreEqual(m1.D, m2[1, 1]);
        }
        [TestMethod]
        public void Test_Operator_Implicit_Conversion()
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            Matrix2d m = a;
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
            Assert.AreEqual(a[0, 0], m.A);
            Assert.AreEqual(a[0, 1], m.B);
            Assert.AreEqual(a[1, 0], m.C);
            Assert.AreEqual(a[1, 1], m.D);
        }
    }
}
