using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Menu
{
    public class MenuOpener : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] GameObject menu;
        [SerializeField] string onClickAnimation;
        Animator animator;
        bool opened;

        void Awake()
        {
            animator = GetComponent<Animator>();

            if (animator == null)
                Debug.LogError($"an animator with {onClickAnimation} animation is required");
        }
        
        void Update()
        {
            if (opened)
            if (Input.GetMouseButtonDown(1))
            {
                opened = false;
                menu.SetActive(opened);
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            animator.Play(onClickAnimation);
            opened = true;
            menu.SetActive(opened);
        }
    }
}
