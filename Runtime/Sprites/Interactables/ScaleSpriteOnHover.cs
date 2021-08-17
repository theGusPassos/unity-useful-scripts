using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Sprites.Interactables
{
    public class ScaleSpriteOnHover : MonoBehaviour
    {
        [SerializeField] float transformScale;
        [SerializeField] float animationSpeed;
        Vector3 targetScale;
        Vector3 onHoverScale;
        Vector3 originalScale;
        float timer;

        void Awake()
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

        void OnMouseEnter()
        {
            timer = 0;
            targetScale = onHoverScale;
        }

        void OnMouseExit()
        {
            timer = 0;
            targetScale = originalScale;
        }
    }
}
