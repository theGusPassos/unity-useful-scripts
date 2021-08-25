using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Menu
{
    public class MenuOpenerOnHover : MonoBehaviour
    {
        [SerializeField] MenuHolder menuHolder;

        void OnMouseEnter()
        {
            menuHolder.OnMenuOpenerHover();
        }
    }
}
