using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Drag
{
    public interface IDragBounds
    {
        bool IsInBounds();
    }

    public class DragBounds : MonoBehaviour, IDragBounds
    {
        public bool IsInBounds() => true;
    }
}
