using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Packages.unity_useful_scripts.Runtime.Ui.Buttons
{
    public class ChangeTextColorOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] Text textMesh;
        [SerializeField] Color onHoverColor;
        [SerializeField] float timeBetweenColors;
        float timer;
        Color targetColor;
        Color originalColor;

        void Start()
        {
            originalColor = targetColor =  textMesh.color;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            targetColor = onHoverColor;
            timer = 0;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            targetColor = originalColor;
            timer = 0;
        }

        void Update()
        {
            if (textMesh.color != targetColor)
            {
                timer += Time.deltaTime;
                textMesh.color = Color.Lerp(textMesh.color, targetColor, timer / timeBetweenColors);
            }
        }
    }
}
