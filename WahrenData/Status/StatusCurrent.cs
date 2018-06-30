using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct StatusCurrent
    {
        public int Length;
        public EntityArray Entities;
        public ComponentDataArray<HpCurrent> Hp;
        public ComponentDataArray<MpCurrent> Mp;
        public ComponentDataArray<AttackCurrent> Attack;
        public ComponentDataArray<DefenseCurrent> Defense;
        public ComponentDataArray<MagicCurrent> Magic;
        public ComponentDataArray<MagdefCurrent> Magdef;
        public ComponentDataArray<SpeedCurrent> Speed;
        public ComponentDataArray<DextCurrent> Dext;
        public ComponentDataArray<MoveCurrent> Move;
        public ComponentDataArray<HprecCurrent> Hprec;
        public ComponentDataArray<MprecCurrent> Mprec;
    }
}