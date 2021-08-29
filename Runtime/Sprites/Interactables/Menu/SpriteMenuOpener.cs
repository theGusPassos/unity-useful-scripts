using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Sprites.Interactables.Menu
{
    public class SpriteMenuOpener : MonoBehaviour
    {
        Vector3 positionWhenClicking;

        void OnMouseDown()
            => positionWhenClicking = transform.position;

        void OnMouseUp()
        {
            if (positionWhenClicking != transform.position)
                return;

            print("clicked");
        }
    }
}
