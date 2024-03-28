using System.Numerics;

namespace ScalableMath;

public partial interface INumber {
    public IList<byte> Bytes { get; }

    public INumber Add(INumber number);
    public INumber Subtract(INumber number);
    public INumber Divide(INumber number);
    public INumber Multiply(INumber number);

    public static INumber Numberify(int number)
    {
        return null;
    }
}