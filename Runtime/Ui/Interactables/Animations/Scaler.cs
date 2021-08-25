using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Ui.Interactables.Animations
{
    public class Scaler : MonoBehaviour
    {
        Vector3 targetScale;
        Vector3 newScale;
        Vector3 originalScale;
        float timer;
        float animationSpeed;

        public void SetUp(float transformScale, float animationSpeed)
        {
            this.animationSpeed = animationSpeed;
            targetScale = originalScale = transform.localScale;
            newScale = transform.localScale * transformScale;
        }

        public void GoToNewScale()
        {
            timer = 0;
            targetScale = newScale;
        }

        public void ResetScale()
        {
            timer = 0;
            targetScale = originalScale;
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
    }
}
