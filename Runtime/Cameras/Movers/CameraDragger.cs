using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Cameras.Movers
{
    public class CameraDragger : MonoBehaviour
    {
        [SerializeField] float dragSpeed;
        Vector3 hitPosition;
        Vector3 currentPosition;
        Vector3 cameraPosition;

        void Update()
        {
            if (Input.GetMouseButtonDown(2))
            {
                hitPosition = Input.mousePosition;
                cameraPosition = transform.position;
            }

            if (Input.GetMouseButton(2))
            {
                currentPosition = Input.mousePosition;
                Vector3 direction = Camera.main.ScreenToWorldPoint(currentPosition) 
                    - Camera.main.ScreenToWorldPoint(hitPosition);
                direction *= -1;
                transform.position = cameraPosition + direction;
            }
        }
    }
}
