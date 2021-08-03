using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.unity_useful_scripts.Runtime.Scenes
{
    public class LoadSceneOnClick : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] string sceneToLoad;

        public void OnPointerDown(PointerEventData eventData)
            => SceneLoader.Instance.LoadScene(sceneToLoad);
    }
}
