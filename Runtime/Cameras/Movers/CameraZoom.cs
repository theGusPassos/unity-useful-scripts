using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Cameras.Movers
{
    public class CameraZoom : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float minZoom;
        [SerializeField] float maxZoom;
        Camera cam;

        void Awake()
        {
            cam = GetComponent<Camera>();
        }

        void LateUpdate()
        {
            if (Input.mouseScrollDelta.y != 0)
            {
                cam.orthographicSize += Input.mouseScrollDelta.y * speed;

                if (cam.orthographicSize > maxZoom)
                    cam.orthographicSize = maxZoom;
                else if (cam.orthographicSize < minZoom)
                    cam.orthographicSize = minZoom;
            }
        }
    }
}
