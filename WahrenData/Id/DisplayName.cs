using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct DisplayName : IComponentData
    {
        public ulong Id;
        public DisplayName(ulong id) => Id = id;
        public bool Equals(in DisplayName other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator DisplayName(ulong value) => new DisplayName(value);
        public static implicit operator DisplayName(IdData value) => new DisplayName { Id = value.Id };
        public static implicit operator ulong(DisplayName value) => value.Id;
    }
}