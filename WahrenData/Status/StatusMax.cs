using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct StatusMax
    {
        public int Length;
        public EntityArray Entities;
        public ComponentDataArray<HpMax> Hp;
        public ComponentDataArray<MpMax> Mp;
        public ComponentDataArray<AttackMax> Attack;
        public ComponentDataArray<DefenseMax> Defense;
        public ComponentDataArray<MagicMax> Magic;
        public ComponentDataArray<MagdefMax> Magdef;
        public ComponentDataArray<SpeedMax> Speed;
        public ComponentDataArray<DextMax> Dext;
        public ComponentDataArray<MoveMax> Move;
        public ComponentDataArray<HprecMax> Hprec;
        public ComponentDataArray<MprecMax> Mprec;
    }
}