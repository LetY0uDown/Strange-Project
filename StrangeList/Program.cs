
StrangeClass strangeClass = new();

StrangeResult<int> result = new();
StrangeClass.StrangeAdding = (result, 5, 10);

strangeClass.StrangeNumbers.Add = 10;
strangeClass.StrangeNumbers.Add = 15;
strangeClass.StrangeNumbers.Add = 69;

Console.Write("Strange numbers:");
foreach (int i in strangeClass.StrangeNumbers.Values)
    Console.Write($" {i}");

Console.WriteLine($"\nStrange result: {result.Result}");

internal sealed class StrangeClass
{
    internal StrangeList<int> StrangeNumbers { get; } = new();

    internal static (StrangeResult<int> result, int one, int two) StrangeAdding {
        set => value.result.Result = value.one + value.two;
    }
}

internal class StrangeResult<T>
{
    internal T Result { get; set; }
}

internal sealed class StrangeList<T>
{
    private readonly List<T> _values = new();

    internal List<T> Values => new(_values);

    internal T Add {
        set => _values.Add(value);
    }

    internal T Remove {
        set => _values.Remove(value);
    }
}