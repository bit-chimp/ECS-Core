namespace src.game.utils.containers
{
    public struct Vector2Int
    {
        public int x;
        public int y;

        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public override bool Equals(object obj)
        {
            var vec = obj is Vector2Int ? (Vector2Int) obj : new Vector2Int();
            return this.x == vec.x && this.y == vec.y;
        }

        public bool Equals(Vector2Int other)
        {
            return x == other.x && y == other.y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x * 397) ^ y;
            }
        }

        public static bool operator ==(Vector2Int a, Vector2Int b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Vector2Int a, Vector2Int b)
        {
            return !(a == b);
        }


        public static bool operator -(Vector2Int a, Vector2Int b)
        {
            return (a - b);
        }


        public override string ToString()
        {
            return x + "," + y;
        }
    }
}