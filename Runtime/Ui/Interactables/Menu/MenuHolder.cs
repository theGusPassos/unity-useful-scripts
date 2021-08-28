using Packages.unity_useful_scripts.Runtime.Ui.Interactables.Animations;
using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Menu
{
    /// <summary>
    /// handles the state of a menu that's opened by
    /// hovering on an area
    /// </summary>
    public class MenuHolder : MonoBehaviour
    {
        [SerializeField] GameObject menu;
        [SerializeField] Scaler scaler;
        [SerializeField] float transformScale;
        [SerializeField] float animationSpeed;

        void Awake()
        {
            scaler.SetUp(transformScale, animationSpeed);
        }

        public void OnMenuOpenerHover()
        {
            //scaler.GoToNewScale();
            menu.SetActive(true);
        }

        public void OnMenuHoverExit()
        {
            //scaler.ResetScale();
            menu.SetActive(false);
        }

        public void ForceClose() => OnMenuHoverExit();
    }
}

