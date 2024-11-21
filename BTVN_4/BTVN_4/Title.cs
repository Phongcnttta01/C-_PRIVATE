namespace BTVN_4
{
    public class Title
    {
        protected Character Character { get; set; }
        protected int X { get; set; }
        protected int Y { get; set; }

        public Title() { }

        public Title(int x, int y)
        {
            Character = null;
            X = x;
            Y = y;
        }

        public Character GetCharacter()
        {
            return Character;
        }

        public void SetCharacter(Character character)
        {
            Character = character;
        }

        public int GetX()
        {
            return X;
        }

        public void SetX(int x)
        {
            X = x;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetY(int y)
        {
            Y = y;
        }

        public bool IsOccupied()
        {
            return Character != null;
        }

        public bool CheckPlayer()
        {
            return Character != null && Character.IsPlayer();
        }
    }
}