using Unity.Entities;
namespace Wahren.Unity.Data
{
    public struct LevelCurrent : IComponentData
    {
        public uint Value;
    }
    public struct LevelMax : IComponentData
    {
        public uint Value;
    }
}