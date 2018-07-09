using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MoveType : IComponentData
    {
        public ulong Id;
        public MoveType(ulong id) => Id = id;
        public bool Equals(in MoveType other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator MoveType(ulong value) => new MoveType(value);
        public static implicit operator MoveType(IdData value) => new MoveType { Id = value.Id };
        public static implicit operator ulong(MoveType value) => value.Id;
    }
}