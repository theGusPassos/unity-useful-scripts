using Packages.unity_useful_scripts.Runtime.Transforms;
using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Sprites.Interactables.Animations
{
    [RequireComponent(typeof(Scaler))]
    public class ScaleOnHover : MonoBehaviour
    {
        [SerializeField] float transformScale;
        [SerializeField] float animationSpeed;
        Scaler scaler;
        bool locked;

        void Awake()
        {
            scaler = GetComponent<Scaler>();
            scaler.SetUp(transformScale, animationSpeed);
        }

        void OnMouseEnter() => scaler.GoToNewScale();

        void OnMouseExit()
        {
            if (!locked) scaler.ResetScale();
        }

        public void ToggleLock()
        {
            if (locked) scaler.ResetScale();
            locked = !locked;
        }
    }
}
