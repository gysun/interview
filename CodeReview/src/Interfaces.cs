namespace MyLibrary;

public interface INumbersGenerator
{
    string GenerateOutput();
}

public interface IRange
{
    int Lower { get; }
    int Upper { get; }
}