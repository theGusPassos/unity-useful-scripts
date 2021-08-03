using UnityEngine;

namespace Packages.unity_useful_scripts.Runtime.Systems
{
    public class Singleton<T> : MonoBehaviour
        where T : Component
    {
        public static T Instance;

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = GetComponent<T>();
                return;
            }

            Destroy(gameObject);
        }
    }
}
