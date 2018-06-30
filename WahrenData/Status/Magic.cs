using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MagicCurrent : IComponentData
    {
        public long Value;
    }
    public struct MagicMax : IComponentData
    {
        public long Value;
    }
    public struct MagicBattleMax : IComponentData
    {
        public long Value;
    }
    public struct MagicLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct MagicLevelUpMax : IComponentData
    {
        public long Value;
    }
}