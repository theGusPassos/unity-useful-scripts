using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Drag
{
    public interface IDragState
    {
        bool CanDrag();
    }

    public class DragState : MonoBehaviour, IDragState
    {
        public bool CanDrag() => true;
    }
}
