using System.Collections.Generic;

namespace src.game.utils.containers
{
    public static class BezierCurve
    {
        public static List<UnityEngine.Vector2> GetPoints(UnityEngine.Vector2 start, UnityEngine.Vector2 middle, UnityEngine.Vector2 end, int numberOfPoints)
        {
            List<UnityEngine.Vector2> points = new List<UnityEngine.Vector2>();
            // set points of quadratic Bezier curve
            UnityEngine.Vector2 p0 = start;
            UnityEngine.Vector2 p1 = middle;
            UnityEngine.Vector2 p2 = end;
            float t;
            UnityEngine.Vector2 position;

            for (int i = 0; i < numberOfPoints; i++)
            {
                t = i / (numberOfPoints - 1.0f);
                position = ((1.0f - t) * (1.0f - t) * p0
                            + 2.0f * (1.0f - t) * t * p1 + t * t * p2);
                points.Add(position);
            }

            return points;
        }
    }
}