using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct AttackCurrent : IComponentData
    {
        public long Value;
    }
    public struct AttackMax : IComponentData
    {
        public long Value;
    }
    public struct AttackBattleMax : IComponentData
    {
        public long Value;
    }
    public struct AttackLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct AttackLevelUpMax : IComponentData
    {
        public long Value;
    }
}