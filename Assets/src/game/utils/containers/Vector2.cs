namespace src.game.utils.containers
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            var vec = obj is Vector2 ? (Vector2) obj : new Vector2();
            return this.x == vec.x && this.y == vec.y;
        }

        
        public bool Equals(Vector2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x.GetHashCode() * 397) ^ y.GetHashCode();
            }
        }

        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a == b);
        }

        public static float operator *(Vector2 a, Vector2 b)
        {
            return a.x * b.x;
        }


        public override string ToString()
        {
            return x + "," + y;
        }
    }
}