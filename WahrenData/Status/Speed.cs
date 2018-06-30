using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct SpeedCurrent : IComponentData
    {
        public long Value;
    }
    public struct SpeedMax : IComponentData
    {
        public long Value;
    }
    public struct SpeedBattleMax : IComponentData
    {
        public long Value;
    }
    public struct SpeedLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct SpeedLevelUpMax : IComponentData
    {
        public long Value;
    }
}