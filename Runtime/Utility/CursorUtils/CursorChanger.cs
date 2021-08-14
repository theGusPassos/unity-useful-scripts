using Packages.unity_useful_scripts.Runtime.Systems;
using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Utility.CursorUtils
{
    public class CursorChanger : Singleton<CursorChanger>
    {
        [SerializeField] Texture2D defaultCursor;
        [SerializeField] Texture2D onButtonCursor;
        [SerializeField] Texture2D onGrabCursor;

        void Start()
            => Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);

        public void ShowOnButtonCursor()
            => Cursor.SetCursor(onButtonCursor, Vector2.zero, CursorMode.Auto);

        public void ShowOnGrabCursor()
            => Cursor.SetCursor(onGrabCursor, Vector2.zero, CursorMode.Auto);

        public void ShowDefaultCursor()
            => Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }
}
