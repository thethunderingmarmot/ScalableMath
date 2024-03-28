namespace ScalableMath;

public partial interface INumber {
    public void Add(INumber number);
    public void Subtract(INumber number);
    public void Divide(INumber number);
    public void Multiply(INumber number);

    public static INumber Numberify(int number) {
        return new ByteArrayNumber(number);
    }
}