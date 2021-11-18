using Abc.Aids.Random;

namespace Abc.Tests {
    public abstract class ClassTests<TBaseClass> : BaseClassTests<TBaseClass> {
        protected override object createObject() => GetRandom.Object(type);
    }

}

