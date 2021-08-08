using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Drag
{
    public class DraggableOnWorldCanvas : MonoBehaviour, IDragHandler
    {
        RectTransform rectTransform;
        [SerializeField] RectTransform canvasRectTransform;

        void Awake() => rectTransform = GetComponent<RectTransform>();

        public void OnDrag(PointerEventData eventData)
        {
            if (!Input.GetMouseButton(0)) return;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRectTransform,
                Input.mousePosition, 
                Camera.main, 
                out Vector2 local);

            rectTransform.anchoredPosition = local;
        }
    }
}
