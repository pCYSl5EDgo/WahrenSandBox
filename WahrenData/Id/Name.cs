using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct Name : IComponentData
    {
        public ulong Id;
        public Name(ulong id) => Id = id;
        public bool Equals(in Name other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator Name(ulong value) => new Name(value);
        public static implicit operator Name(IdData value) => new Name { Id = value.Id };
        public static implicit operator ulong(Name value) => value.Id;
    }
}