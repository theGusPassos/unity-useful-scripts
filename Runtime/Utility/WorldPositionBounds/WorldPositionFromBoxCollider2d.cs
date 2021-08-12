using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Utility.WorldPositionBounds
{
    public class WorldPositionFromBoxCollider2d : MonoBehaviour, IWorldPositionBounds
    {
        [SerializeField] GameObject objWithBoxCollider2d;
        BoxCollider2D boxCollider2D;
        public PositionBounds Bounds { get; private set; }

        void Awake()
        {
            boxCollider2D = objWithBoxCollider2d.GetComponent<BoxCollider2D>();
            Bounds = new PositionBounds()
            {
                maxX = boxCollider2D.bounds.max.x,
                minX = boxCollider2D.bounds.min.x,
                maxY = boxCollider2D.bounds.max.y,
                minY = boxCollider2D.bounds.min.y
            };
        }
    }
}
