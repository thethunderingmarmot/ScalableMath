using System.Numerics;

namespace ScalableMath;

public interface INumber
{
    public const byte DEFAULT_VALUE = 0;

    public IList<byte> Bytes { get; }

    public INumber Add(INumber number);
    public INumber Subtract(INumber number);
    public INumber Divide(INumber number);
    public INumber Multiply(INumber number);
}