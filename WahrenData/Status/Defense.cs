using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct DefenseCurrent : IComponentData
    {
        public long Value;
    }
    public struct DefenseMax : IComponentData
    {
        public long Value;
    }
    public struct DefenseBattleMax : IComponentData
    {
        public long Value;
    }
    public struct DefenseLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct DefenseLevelUpMax : IComponentData
    {
        public long Value;
    }
}