using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Utility.WorldPositionBounds
{
    public interface IWorldPositionBounds
    {
        public PositionBounds Bounds { get; }
    }

    public class PositionBounds
    {
        public float maxX;
        public float minX;
        public float maxY;
        public float minY;

        public float GetFixedX(float x)
        {
            if (x > maxX)
                return maxX;
            if (x < minX)
                return minX;

            return x;
        } 

        public float GetFixedY(float y)
        {
            if (y > maxY)
                return maxY;
            if (y < minY)
                return minY;

            return y;
        }

        public Vector3 GetFixedPos(Vector3 pos)
        {
            pos.x = GetFixedX(pos.x);
            pos.y = GetFixedX(pos.y);
            return pos;
        }
    }
}
