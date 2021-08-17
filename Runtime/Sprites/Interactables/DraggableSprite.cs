using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Sprites.Interactables
{
    public class DraggableSprite : MonoBehaviour
    {
        Vector3 screenPoint;
        Vector3 offset;

        void OnMouseDown()
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        void OnMouseDrag()
        {
            var curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }
}
