using Matrix2dLib;

namespace Matrix2dConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = new Matrix2d();
            var m3 = new Matrix2d(1, 2, 3, 4);

            Console.WriteLine($"=== Matrix 1, 2, 3, 4 ===\n{m1}\n");
            Console.WriteLine($"=== Matrix with empty constructor ===\n{m2}\n");
            Console.WriteLine($"=== Identity matrix ===\n{Matrix2d.Id}\n");
            Console.WriteLine($"=== Zero matrix ===\n{Matrix2d.Zero}\n");

            Console.WriteLine($"=== Equals Method ===\n{m1.Equals(m3)}\n");
            Console.WriteLine($"=== m1 == m3 ===\n{m1 == m3}\n");
            Console.WriteLine($"=== m1 != m2 ===\n{m1 != m2}\n");
            Console.WriteLine($"=== m1 == m2 ===\n{m1 == m2}\n");
            Console.WriteLine($"=== m1 != m3 ===\n{m1 != m3}\n");

            Console.WriteLine($"=== m1 + m2 ===\n{m1 + m2}\n");
            Console.WriteLine($"=== m1 - m2 ===\n{m1 - m2}\n");
            Console.WriteLine($"=== m1 * m2 ===\n{m1 * m2}\n");
            Console.WriteLine($"=== m1 * m3 ===\n{m1 * m3}\n");
            Console.WriteLine($"=== -m1 ===\n{-m1}\n");

            int[,] intArray = (int[,])m1;
            Console.WriteLine("=== Conversion from Matrix2d to int[,] ===");
            Console.WriteLine($"[{intArray[0, 0]}, {intArray[0, 1]}], [{intArray[1, 0]}, {intArray[1, 1]}]\n");

            Matrix2d m4 = intArray;
            Console.WriteLine($"=== Conversion from int[,] to Matrix2d ===\n{m4}\n");

            var m5 = Matrix2d.Parse("[5, 6], [7, 8]");
            Console.WriteLine($"=== Parse Method ===\n{m5}\n");

            var m6 = Matrix2d.Transpose(m5);
            Console.WriteLine($"=== Transpose Method ===\n{m6}\n");

            Console.WriteLine("=== Determinant Method ===");
            Console.WriteLine($"m6.Det(): {m6.Det()}");
            Console.WriteLine($"Matrix2d.Determinant(m6): {Matrix2d.Determinant(m6)}\n");
        }
    }
}