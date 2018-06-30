using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct StatusLevelUpGrow
    {
        public int Length;
        public EntityArray Entities;
        public ComponentDataArray<HpLevelUpGrow> Hp;
        public ComponentDataArray<MpLevelUpGrow> Mp;
        public ComponentDataArray<AttackLevelUpGrow> Attack;
        public ComponentDataArray<DefenseLevelUpGrow> Defense;
        public ComponentDataArray<MagicLevelUpGrow> Magic;
        public ComponentDataArray<MagdefLevelUpGrow> Magdef;
        public ComponentDataArray<SpeedLevelUpGrow> Speed;
        public ComponentDataArray<DextLevelUpGrow> Dext;
        public ComponentDataArray<MoveLevelUpGrow> Move;
        public ComponentDataArray<HprecLevelUpGrow> Hprec;
        public ComponentDataArray<MprecLevelUpGrow> Mprec;
    }
}