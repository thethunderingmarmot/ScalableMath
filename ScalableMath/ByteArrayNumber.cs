
namespace ScalableMath;

public class ByteArrayNumber : INumber
{
    private byte[] _bytes;
    public IList<byte> Bytes => _bytes;

    public ByteArrayNumber(byte[] bytes)
    {
        _bytes = bytes;
    }
    public ByteArrayNumber() : this([INumber.DEFAULT_VALUE]) {}

    public INumber Add(INumber number)
    {
        throw new NotImplementedException();
    }

    public INumber Divide(INumber number)
    {
        throw new NotImplementedException();
    }

    public INumber Multiply(INumber number)
    {
        throw new NotImplementedException();
    }

    public INumber Subtract(INumber number)
    {
        throw new NotImplementedException();
    }
}