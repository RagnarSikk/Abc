using Abc.Aids.Random;

namespace Abc.Tests
{
    public abstract class ClassTests<TClass, TBaseClass> :
        BaseClassTests<TClass, TBaseClass> where TClass : class
    {
        protected override TClass createObject() => GetRandom.Object<TClass>();
    }

}

