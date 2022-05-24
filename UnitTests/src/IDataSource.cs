namespace MyLibrary;

/// <summary>
/// Represents the data source.
/// </summary>
public interface IDataSource
{
    /// <summary>
    /// Gets a series of numbers.
    /// </summary>
    /// <returns>A list of int.</returns>
    IEnumerable<int> GetNumbers();
}