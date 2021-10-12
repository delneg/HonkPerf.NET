﻿namespace HonkPerf.NET.RefLinq;

static partial class LazyLinqExtensions
{
    public static RefLinqEnumerable<T, Concat<T, TEnumerator1, TEnumerator2>> Concat<T, TEnumerator1, TEnumerator2>(
        this RefLinqEnumerable<T, TEnumerator1> seq1, RefLinqEnumerable<T, TEnumerator2> seq2)
        where TEnumerator1 : IRefEnumerable<T>
        where TEnumerator2 : IRefEnumerable<T>
        => new(new(seq1.enumerator, seq2.enumerator));


}