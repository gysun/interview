namespace MyLibrary
{
    public interface INumbersGenerator
    {
        string GenerateOutput();
    }

    public interface IRange
    {
        int lower { get; }
        int upper { get; }
    }
}