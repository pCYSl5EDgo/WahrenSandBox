using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct HprecCurrent : IComponentData
    {
        public long Value;
    }
    public struct HprecMax : IComponentData
    {
        public long Value;
    }
    public struct HprecBattleMax : IComponentData
    {
        public long Value;
    }
    public struct HprecLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct HprecLevelUpMax : IComponentData
    {
        public long Value;
    }
}