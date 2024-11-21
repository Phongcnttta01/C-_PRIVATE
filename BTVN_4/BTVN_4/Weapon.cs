namespace BTVN_4
{
    public class Weapon
    {
        protected string WeaponName { get; set; }
        protected int Attack { get; set; }
        protected int RangeAttack { get; set; }

        public Weapon(string weaponName, int attack, int rangeAttack)
        {
            WeaponName = weaponName;
            Attack = attack;
            RangeAttack = rangeAttack;
        }
    }
}