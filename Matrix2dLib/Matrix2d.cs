#nullable enable
namespace Matrix2dLib;

//immutable 2x2 matrix
public class Matrix2d
{
    private int _a, _b, _c, _d;

    //constructor
    public Matrix2d(int a, int b, int c, int d)
    {
        _a = a;
        _b = b;
        _c = c;
        _d = d;
    }
    public Matrix2d() : this(1, 0, 0, 1) { }

    //properties
    public int A => _a;
    public int B => _b;
    public int C => _c;
    public int D => _d;

    public static Matrix2d Id => new Matrix2d();

    public static Matrix2d Zero => new Matrix2d(0, 0, 0, 0);

    //methods
    override public string ToString() => $"[{_a}, {_b}], [{_c}, {_d}]";

    #region Equals
    public bool Equals(Matrix2d other)
    {
        if(other is null) return false;
        return _a == other._a &&
            _b == other._b && 
            _c == other._c && 
            _d == other._d;
    }

    public static bool operator ==(Matrix2d left, Matrix2d right) 
        => left.Equals(right);
    public static bool operator !=(Matrix2d left, Matrix2d right)
        => !left.Equals(right);
    #endregion

    #region Arytmetyka
    public static Matrix2d operator +(Matrix2d left, Matrix2d right)
        => new Matrix2d(left._a + right._a, 
                        left._b + right._b, 
                        left._c + right._c, 
                        left._d + right._d);

    public static Matrix2d operator -(Matrix2d left, Matrix2d right)
        => new Matrix2d(left._a - right._a,
                        left._b - right._b,
                        left._c - right._c,
                        left._d - right._d);
    public static Matrix2d operator *(Matrix2d left, Matrix2d right)
        => new Matrix2d(left._a * right._a + left._b * right._c,
                        left._a * right._b + left._b * right._d,
                        left._c * right._a + left._d * right._c,
                        left._c * right._b + left._d * right._d);

    public static Matrix2d operator *(Matrix2d left, int right)
        => new Matrix2d(left._a * right,
                        left._b * right,
                        left._c * right,
                        left._d * right);

    public static Matrix2d operator *(int left, Matrix2d right)
        => new Matrix2d(right._a * left,
                        right._b * left,
                        right._c * left,
                        right._d * left);

    public static Matrix2d operator -(Matrix2d matrix)
        => new Matrix2d(-matrix._a,
                        -matrix._b,
                        -matrix._c,
                        -matrix._d);

    #endregion

}

