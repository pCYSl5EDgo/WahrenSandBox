using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MagdefCurrent : IComponentData
    {
        public long Value;
    }
    public struct MagdefMax : IComponentData
    {
        public long Value;
    }
    public struct MagdefBattleMax : IComponentData
    {
        public long Value;
    }
    public struct MagdefLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct MagdefLevelUpMax : IComponentData
    {
        public long Value;
    }
}