
namespace ScalableMath;

public partial interface INumber {
    private class ByteArray : INumber
    {
        private byte[] _bytes;
        public IList<byte> Bytes => _bytes;

        private ByteArray() {
            _bytes = [0x00];
        }

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