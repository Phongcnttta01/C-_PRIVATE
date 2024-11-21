using System;

namespace BTVN_4
{
    public class Player : Character
    {
        protected Weapon Weapon;

        public Player(int posX, int posY, int damage, int rangeAttack, int healthPoint, Weapon weapon)
            : base(posX, posY, damage, rangeAttack, healthPoint)
        {
            Weapon = weapon;
        }

        public override bool IsPlayer()
        {
            return true;
        }

        public override void Attack(Character enemy)
        {
            if (Math.Abs(this.PosX - enemy.PosX) <= RangeAttack && Math.Abs(this.PosY - enemy.PosY) <= RangeAttack)
            {
                // Tấn công: Logic trúng đòn (giảm máu đối thủ)
                enemy.HealthPoint -= this.Damage; // Giảm máu đối thủ (có thể thay đổi tùy theo game)
            }
        }

        public void Move(int x, int y, int width, int height)
        {
            char move = Console.ReadKey().KeyChar; // Lấy ký tự nhập từ bàn phím
            if (move == 'a' && this.PosX > 0) this.PosX -= 1;
            if (move == 'w' && this.PosY > 0) this.PosY -= 1;
            if (move == 'd' && this.PosX < width - 1) this.PosX += 1;
            if (move == 's' && this.PosY < height - 1) this.PosY += 1;
        }
    }
}