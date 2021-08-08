using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Drag
{
    public class Draggable : MonoBehaviour, IDragHandler
    {
        IDragState dragState;
        IDragBounds dragBounds;
        RectTransform rectTransform;

        private void Awake()
        {
            dragState = GetComponent<IDragState>();
            dragBounds = GetComponent<IDragBounds>();
            rectTransform = GetComponent<RectTransform>();
        }
        
        public void OnDrag(PointerEventData eventData)
        {
            if (!Input.GetMouseButton(0) 
                || !dragState.CanDrag()) return;

            rectTransform.position += (Vector3)eventData.delta;
        }
    }
}
