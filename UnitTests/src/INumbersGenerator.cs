namespace MyLibrary;

/// <summary>
/// Represents the numbers generator.
/// </summary>
public interface INumbersGenerator
{
    /// <summary>
    /// Gets the special numbers.
    /// </summary>
    /// <param name="min">The min value.</param>
    /// <param name="max">The max value.</param>
    /// <returns>A list of int.</returns>
    IEnumerable<int> GetSpecialNumbers(int min, int max);
}