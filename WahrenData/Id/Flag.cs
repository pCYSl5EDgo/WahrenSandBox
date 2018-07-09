using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct Flag : IComponentData
    {
        public ulong Id;
        public Flag(ulong id) => Id = id;
        public bool Equals(in Flag other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator Flag(ulong value) => new Flag(value);
        public static implicit operator Flag(IdData value) => new Flag { Id = value.Id };
        public static implicit operator ulong(Flag value) => value.Id;
    }
}