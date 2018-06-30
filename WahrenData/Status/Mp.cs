using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MpCurrent : IComponentData
    {
        public long Value;
    }
    public struct MpMax : IComponentData
    {
        public long Value;
    }
    public struct MpBattleMax : IComponentData
    {
        public long Value;
    }
    public struct MpLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct MpLevelUpMax : IComponentData
    {
        public long Value;
    }
}