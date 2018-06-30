using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct MoveCurrent : IComponentData
    {
        public long Value;
    }
    public struct MoveMax : IComponentData
    {
        public long Value;
    }
    public struct MoveBattleMax : IComponentData
    {
        public long Value;
    }
    public struct MoveLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct MoveLevelUpMax : IComponentData
    {
        public long Value;
    }
}