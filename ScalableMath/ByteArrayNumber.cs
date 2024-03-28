namespace ScalableMath;

public partial interface INumber {
    private struct ByteArrayNumber : INumber {
        private byte[] data;

        public int Bytes => data.Length;

        public ByteArrayNumber(int number) {
            data = BitConverter.GetBytes(number);
        }

        public void Add(INumber number)
        {
            throw new NotImplementedException();
        }

        public void Subtract(INumber number)
        {
            throw new NotImplementedException();
        }

        public void Divide(INumber number)
        {
            throw new NotImplementedException();
        }

        public void Multiply(INumber number)
        {
            throw new NotImplementedException();
        }
    }
}