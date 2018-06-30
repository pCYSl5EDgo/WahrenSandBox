using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct StatusLevelUpMax
    {
        public int Length;
        public EntityArray Entities;
        public ComponentDataArray<HpLevelUpMax> Hp;
        public ComponentDataArray<MpLevelUpMax> Mp;
        public ComponentDataArray<AttackLevelUpMax> Attack;
        public ComponentDataArray<DefenseLevelUpMax> Defense;
        public ComponentDataArray<MagicLevelUpMax> Magic;
        public ComponentDataArray<MagdefLevelUpMax> Magdef;
        public ComponentDataArray<SpeedLevelUpMax> Speed;
        public ComponentDataArray<DextLevelUpMax> Dext;
        public ComponentDataArray<MoveLevelUpMax> Move;
        public ComponentDataArray<HprecLevelUpMax> Hprec;
        public ComponentDataArray<MprecLevelUpMax> Mprec;
    }
}