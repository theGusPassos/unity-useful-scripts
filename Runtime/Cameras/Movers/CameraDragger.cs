using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Cameras.Movers
{
    public class CameraDragger : MonoBehaviour
    {
        [SerializeField] float dragSpeed;
        Vector3 dragOrigin;

        void Update()
        {
            if (Input.GetMouseButtonDown(2))
            {
                dragOrigin = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(2)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);
            transform.Translate(move, Space.World);
        }
    }
}
