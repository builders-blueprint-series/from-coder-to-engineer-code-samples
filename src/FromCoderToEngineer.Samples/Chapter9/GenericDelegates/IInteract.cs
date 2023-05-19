using System;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    public interface IInteract<T>
    {
        TResult Interact<TResult>(Func<IEnumerable<T>, TResult> func);
    }
}