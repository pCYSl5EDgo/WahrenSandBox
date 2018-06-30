using Unity.Entities;
namespace Wahren.Unity.Data
{
    public struct ExpCurrent : IComponentData
    {
        public ulong Value;
    }
    public struct ExpMax : IComponentData
    {
        public ulong Value;
    }
    public struct ExpUp : IComponentData
    {
        public ulong Value;
    }
    public struct ExpMul : IComponentData
    {
        public ulong Value;
    }
}