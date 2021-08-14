using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Utility.CursorUtils
{
    public class ChangeCursorOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
            => CursorChanger.Instance.ShowOnButtonCursor();

        public void OnPointerExit(PointerEventData eventData)
            => CursorChanger.Instance.ShowDefaultCursor();
    }
}
