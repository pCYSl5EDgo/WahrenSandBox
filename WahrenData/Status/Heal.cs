using Unity.Entities;
namespace Wahren.Unity.Data
{
    public struct HealBattleCurrent : IComponentData
    {
        public long Value;
    }
    public struct HealBattleMax : IComponentData
    {
        public long Value;
    }
}