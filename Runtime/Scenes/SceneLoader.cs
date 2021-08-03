using Packages.unity_useful_scripts.Runtime.Systems;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Packages.unity_useful_scripts.Runtime.Scenes
{
    public class SceneLoader : Singleton<SceneLoader>
    {
        [SerializeField] string onEnterAnimation;
        [SerializeField] string onExitAnimation;
        [SerializeField] float transitionTime;
        [SerializeField] Animator animator;

        private void Start()
            => animator = GetComponentInChildren<Animator>();

        public void LoadScene(string level)
            => StartCoroutine(LoadSceneWithTransition(level));

        private void OnLevelWasLoaded(int level)
        {
            animator = GetComponentInChildren<Animator>();
            animator.Play(onEnterAnimation);
        }

        IEnumerator LoadSceneWithTransition(string level)
        {
            animator.Play(onExitAnimation);
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(level);
        }
    }
}
