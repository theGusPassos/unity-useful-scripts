using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Animations
{
    public class ScaleOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
    {
        [SerializeField] float transformScale;
        [SerializeField] float animationSpeed;
        Vector3 targetScale;
        Vector3 onHoverScale;
        Vector3 originalScale;
        float timer;

        private void Awake()
        {
            targetScale = originalScale = transform.localScale;
            onHoverScale = transform.localScale * transformScale;
        }

        void Update()
        {
            if (transform.localScale != targetScale)
            {
                transform.localScale = Vector3.Lerp(
                    transform.localScale,
                    targetScale,
                    timer / animationSpeed);

                timer += Time.deltaTime;
            }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            timer = 0;
            targetScale = onHoverScale;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            timer = 0;
            targetScale = originalScale;
        }
    }
}
