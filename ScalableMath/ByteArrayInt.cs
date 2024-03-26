namespace ScalableMath;

public struct ByteArrayInt : IScalableInt {
    private byte[] data;

    public int Bytes => data.Length;

    public ByteArrayInt(int number) {
        data = BitConverter.GetBytes(number);
    }
}