using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct Description : IComponentData
    {
        public ulong Id;
        public Description(ulong id) => Id = id;
        public bool Equals(in Description other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator Description(ulong value) => new Description(value);
        public static implicit operator Description(IdData value) => new Description { Id = value.Id };
        public static implicit operator ulong(Description value) => value.Id;
    }
}