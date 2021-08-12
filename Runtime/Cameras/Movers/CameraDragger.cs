using Packages.unity_useful_scripts.Runtime.Utility.WorldPositionBounds;
using System;
using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Cameras.Movers
{
    public class CameraDragger : MonoBehaviour
    {
        [SerializeField] float dragSpeed;
        Vector3 hitPosition;
        Vector3 currentPosition;
        Vector3 cameraPosition;
        IWorldPositionBounds bounds;

        Action updateFn;

        void Awake()
        {
            bounds = GetComponent<IWorldPositionBounds>();
            if (bounds == null)
                updateFn = UpdateWithoutBounds;
            else updateFn = UpdateWithBounds;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(2))
            {
                hitPosition = Input.mousePosition;
                cameraPosition = transform.position;
            }

            if (Input.GetMouseButton(2))
                updateFn();
        }

        void UpdateWithoutBounds()
        {
            currentPosition = Input.mousePosition;
            Vector3 direction = Camera.main.ScreenToWorldPoint(currentPosition)
                - Camera.main.ScreenToWorldPoint(hitPosition);
            direction *= -1;
            transform.position = cameraPosition + direction;
        }

        void UpdateWithBounds()
        {
            currentPosition = Input.mousePosition;
            Vector3 direction = Camera.main.ScreenToWorldPoint(currentPosition)
                - Camera.main.ScreenToWorldPoint(hitPosition);
            direction *= -1;
            var futurePos = cameraPosition + direction;
            transform.position = bounds.Bounds.GetFixedPos(futurePos);
        }
    }
}
