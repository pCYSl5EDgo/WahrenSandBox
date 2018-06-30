using Unity.Entities;

namespace Wahren.Unity.Data.Unit
{
    public struct AttackRange : IComponentData
    {
        public float Value;
    }
    public struct EscapeRange : IComponentData
    {
        public float Value;
    }
    public struct EscapeRun : IComponentData
    {
        public float Value;
    }
    public struct HandRange : IComponentData
    {
        public float Value;
    }
    public struct WakeRange : IComponentData
    {
        public float Value;
    }
    public struct ViewRange : IComponentData
    {
        public float Value;
    }
    public struct CavalryRange : IComponentData
    {
        public float Value;
    }
}