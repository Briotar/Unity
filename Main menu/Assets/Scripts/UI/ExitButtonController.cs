using UnityEngine;
using UnityEditor;

namespace UI
{
    [RequireComponent(typeof(ExitButtonView))]

    public class ExitButtonController : MonoBehaviour
    {
        private ExitButtonView _exit;

        private void Start()
        {
            _exit = GetComponent<ExitButtonView>();

            _exit.ExitEvent += () =>
            {
                EditorApplication.isPlaying = false;
                //Application.Quit();
            };
        }
    }
}

