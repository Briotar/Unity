using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

namespace UI
{
    public class ExitButtonController : MonoBehaviour
    {
        public void OnButton()
        {

            EditorApplication.isPlaying = false;
            //Application.Quit();
        }
    }
}

