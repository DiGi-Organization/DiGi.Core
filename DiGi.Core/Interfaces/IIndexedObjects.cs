using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that contains a collection of indexed objects.</summary>
    [SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Public interface implemented across the workspace; renaming is a breaking change.")]
    [SuppressMessage("Design", "CA1010:Generic interface should also be implemented", Justification = "The generic contract is IIndexedObjects<T>; this non-generic base is deliberate.")]
    public interface IIndexedObjects : IObject, IEnumerable
    {
    }

    /// <summary>Defines a generic contract for an object that contains a collection of indexed objects of type T.</summary>
    /// <typeparam name="T">The type of the indexed objects.</typeparam>
    public interface IIndexedObjects<T> : IIndexedObjects, IEnumerable<T>
    {
    }
}