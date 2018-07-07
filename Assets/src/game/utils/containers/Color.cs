namespace src.game.utils.containers
{
    public struct Color
    {
        public float r;
        public float g;
        public float b;
        public float a;
        public static Color white = new Color(1, 1, 1, 1);

        public Color(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }


        public override bool Equals(object obj)
        {
            var vec = obj is Color ? (Color) obj : new Color();
            return this.r == vec.r && this.g == vec.g && this.b == vec.b && this.a == vec.a;
        }

        public bool Equals(Color other)
        {
            return r.Equals(other.r) && g.Equals(other.g) && b.Equals(other.b) && a.Equals(other.a);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = r.GetHashCode();
                hashCode = (hashCode * 397) ^ g.GetHashCode();
                hashCode = (hashCode * 397) ^ b.GetHashCode();
                hashCode = (hashCode * 397) ^ a.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Color a, Color b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Color a, Color b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "R:" + r + " G:" + g + " B:" + b + " A:" + a;
        }
    }
}