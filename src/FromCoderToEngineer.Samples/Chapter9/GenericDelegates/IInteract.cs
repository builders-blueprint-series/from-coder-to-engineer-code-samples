namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    using System;
    using System.Collections.Generic;

    public interface IInteract<T>
    {
        TResult Interact<TResult>(Func<IEnumerable<T>, TResult> func);
    }
}
