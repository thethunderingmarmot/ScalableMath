namespace ScalableMath;

public partial interface INumber
{
    private class ByteListNumber : INumber
    {
        private List<byte> _bytes;
        public IList<byte> Bytes => _bytes;

        public ByteListNumber(List<byte> bytes)
        {
            _bytes = bytes;
        }
        public ByteListNumber() : this([DEFAULT_VALUE]) {}

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
}