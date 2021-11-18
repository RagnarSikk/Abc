namespace Abc.Domain.Common {
    public interface IPersonEntity : IUniqueEntity {
        public string LastName { get; }
        public string FirstMidName { get; }
        public string FullName { get; }
    }
}