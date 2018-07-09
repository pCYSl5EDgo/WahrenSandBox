using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct Bgm : IComponentData
    {
        public ulong Id;
        public Bgm(ulong id) => Id = id;
        public bool Equals(in Bgm other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator Bgm(ulong value) => new Bgm(value);
        public static implicit operator Bgm(IdData value) => new Bgm { Id = value.Id };
        public static implicit operator ulong(Bgm value) => value.Id;
    }
}