using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct Image : IComponentData
    {
        public ulong Id;
        public Image(ulong id) => Id = id;
        public bool Equals(in Image other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator Image(ulong value) => new Image(value);
        public static implicit operator Image(IdData value) => new Image { Id = value.Id };
        public static implicit operator ulong(Image value) => value.Id;
    }
}