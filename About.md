# CodeReview:
- Naming of Class1
- Constructor to init lower and upper
- ArgumentOutOfRangeException(nameof(lower), ...)
- GenerateOutput => string.Join(", ", Enumerable.Range(_lower, _upper - _lower + 1));
- Comments to public methods
- Extensions => IntegerExtensions
- IRange.lower/upper => Lower/Upper
- Not used namespace in OddNumbersGenerator
- OddNumbersGenerator.Range => use Constructor to init.
- OddNumbersGenerator: update the loop with LINQ
- OddNumbersGenerator.GenerateOutput => no need to re-calculate the min and max.
- UnitTests: add DisplayName to Fact
- Naming of Tests
- Act & Arrange & Assert
- 'var range' in TestOddNumbersGenerator not used.

# Algorithm
- Use 2 stacks in MyStack internally.
- Push the min items twice when Push(), and Pop twice if equals minElement field.