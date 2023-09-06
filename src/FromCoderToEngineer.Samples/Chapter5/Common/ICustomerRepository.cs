using FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections;
using System;

namespace FromCoderToEngineer.Samples.Chapter5.Common
{
    public interface ICustomerRepository
    {
        Customer FindById(Guid id);
    }
}
