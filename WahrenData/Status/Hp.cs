using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct HpCurrent : IComponentData
    {
        public long Value;
    }
    public struct HpMax : IComponentData
    {
        public long Value;
    }
    public struct HpBattleMax : IComponentData
    {
        public long Value;
    }
    public struct HpLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct HpLevelUpMax : IComponentData
    {
        public long Value;
    }
}