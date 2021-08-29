using Packages.unity_useful_scripts.Runtime.Utility.CursorUtils;
using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Sprites.Ui
{
    public class ChangeToButtonOnSpriteHover : MonoBehaviour
    {
        void OnMouseEnter()
            => CursorChanger.Instance.ShowOnButtonCursor();

        void OnMouseExit()
            => CursorChanger.Instance.ShowDefaultCursor();
    }
}
