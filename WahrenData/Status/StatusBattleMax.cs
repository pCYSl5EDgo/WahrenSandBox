using Unity.Entities;

namespace Wahren.Unity.Data
{
    public struct StatusBattleMax
    {
        public int Length;
        public EntityArray Entities;
        public ComponentDataArray<HpBattleMax> Hp;
        public ComponentDataArray<MpBattleMax> Mp;
        public ComponentDataArray<AttackBattleMax> Attack;
        public ComponentDataArray<DefenseBattleMax> Defense;
        public ComponentDataArray<MagicBattleMax> Magic;
        public ComponentDataArray<MagdefBattleMax> Magdef;
        public ComponentDataArray<SpeedBattleMax> Speed;
        public ComponentDataArray<DextBattleMax> Dext;
        public ComponentDataArray<MoveBattleMax> Move;
        public ComponentDataArray<HprecBattleMax> Hprec;
        public ComponentDataArray<MprecBattleMax> Mprec;
    }
}