using System;

namespace BTVN_4
{
    public class Enemy : Character
    {
        public Enemy(int posX, int posY, int damage, int rangeAttack, int healthPoint)
            : base(posX, posY, damage, rangeAttack, healthPoint)
        {
        }

        public void MoveRandom()
        {
            Random random = new Random();
            int deltaX = random.Next(-1, 2); // Tạo số ngẫu nhiên -1, 0, hoặc 1
            int deltaY = random.Next(-1, 2); // Tạo số ngẫu nhiên -1, 0, hoặc 1

            // Cập nhật vị trí, đảm bảo trong phạm vi 10x10
            this.PosX = Math.Max(0, Math.Min(9, PosX + deltaX));
            this.PosY = Math.Max(0, Math.Min(9, PosY + deltaY));
        }

        override 
        public void Attack(Character enemy)
        {
            if (Math.Abs(this.PosX - enemy.PosX) <= RangeAttack && Math.Abs(this.PosY - enemy.PosY) <= RangeAttack)
            {
                // Tấn công: Logic trúng đòn (giảm máu đối thủ)
                enemy.HealthPoint -= this.Damage; // Giảm máu đối thủ (có thể thay đổi tùy theo game)
            }
        }

        public override bool IsPlayer()
        {
            return false;
        }
    }
}