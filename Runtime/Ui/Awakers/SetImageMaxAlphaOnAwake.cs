using UnityEngine;
using UnityEngine.UI;

namespace Packages.unity_useful_scripts.Runtime.Ui.Awakers
{
    public class SetImageMaxAlphaOnAwake : MonoBehaviour
    {
        void Awake()
        {
            GetComponent<Image>().color += new Color(0, 0, 0, 1);
        }
    }
}
