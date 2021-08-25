using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Menu
{
    /// <summary>
    /// the area should overlap the menu opener area 
    /// </summary>
    public class MenuArea : MonoBehaviour
    {
        [SerializeField] MenuHolder menuHolder;

        void OnMouseExit()
        {
            menuHolder.OnMenuHoverExit();
        }
    }
}
