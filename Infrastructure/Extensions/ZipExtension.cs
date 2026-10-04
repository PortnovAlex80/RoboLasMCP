using System;
using System.Collections.Generic;

namespace ZipExtansion
{
    public static class ZipExtension
    {
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            Func<TFirst, TSecond, TResult> func)
        {
            using (var enumeratorA = first.GetEnumerator())
            using (var enumeratorB = second.GetEnumerator())
            {
                while (enumeratorA.MoveNext())
                {
                    enumeratorB.MoveNext();
                    yield return func(enumeratorA.Current, enumeratorB.Current);
                }
            }
        }
    }
}
