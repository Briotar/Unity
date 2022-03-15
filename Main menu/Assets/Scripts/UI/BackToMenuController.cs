using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class BackToMenuController : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;

        public void OnButton()
        {
            gameObject.SetActive(false);
            _mainMenu.SetActive(true);
        }
    }
}
