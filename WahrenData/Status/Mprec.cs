using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MprecCurrent : IComponentData
    {
        public long Value;
    }
    public struct MprecMax : IComponentData
    {
        public long Value;
    }
    public struct MprecBattleMax : IComponentData
    {
        public long Value;
    }
    public struct MprecLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct MprecLevelUpMax : IComponentData
    {
        public long Value;
    }
}