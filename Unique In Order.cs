using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        if (iterable == null)
            return Enumerable.Empty<T>();

        return iterable.Where((x, i) => i == 0 || !x.Equals(iterable.ElementAt(i - 1)));
    }
}
