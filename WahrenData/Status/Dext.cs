using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct DextCurrent : IComponentData
    {
        public long Value;
    }
    public struct DextMax : IComponentData
    {
        public long Value;
    }
    public struct DextBattleMax : IComponentData
    {
        public long Value;
    }
    public struct DextLevelUpGrow : IComponentData
    {
        public long Value;
    }
    public struct DextLevelUpMax : IComponentData
    {
        public long Value;
    }
}