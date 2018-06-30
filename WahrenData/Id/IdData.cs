using System;
using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct IdData : IComponentData
    {
        public IdData(ulong id) => Id = id;
        public ulong Id;
        public bool Equals(in IdData other) => Id == other.Id;
        public override int GetHashCode() => (int)Id;
        public static implicit operator IdData(ulong value) => new IdData(value);
        public static explicit operator ulong(IdData value) => value.Id;
    }
}