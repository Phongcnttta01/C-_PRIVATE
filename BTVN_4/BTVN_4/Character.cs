namespace BTVN_4
{
    public abstract class Character
    {
        protected internal int PosX;
        protected internal int PosY;
        protected int Damage;
        protected int RangeAttack;
        protected internal int HealthPoint;

        public Character() { }

        public Character(int posX, int posY, int damage, int rangeAttack, int healthPoint)
        {
            PosX = posX;
            PosY = posY;
            Damage = damage;
            RangeAttack = rangeAttack;
            HealthPoint = healthPoint;
        }

        public int GetHealthPoint()
        {
            return HealthPoint;
        }

        public void SetHealthPoint(int healthPoint)
        {
            HealthPoint = healthPoint;
        }

        public int GetPosX()
        {
            return PosX;
        }

        public void SetPosX(int posX)
        {
            PosX = posX;
        }

        public int GetPosY()
        {
            return PosY;
        }

        public void SetPosY(int posY)
        {
            PosY = posY;
        }

        public int GetDamage()
        {
            return Damage;
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }

        public int GetRangeAttack()
        {
            return RangeAttack;
        }

        public void SetRangeAttack(int rangeAttack)
        {
            RangeAttack = rangeAttack;
        }

        public void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public bool CheckRangeAttack(Character target)
        {
            int distance = Math.Abs(PosX - target.PosX) + Math.Abs(PosY - target.PosY);
            return distance <= RangeAttack;
        }

        public virtual void Attack(Character target)
        {
            // Implement attack logic here
        }

        public abstract bool IsPlayer();
    }
}