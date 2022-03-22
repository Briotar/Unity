using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(BackToMenuView))]

    public class BackToMenuController : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu;

        private BackToMenuView _backToMenu;

        private void Start()
        {
            _backToMenu = GetComponent<BackToMenuView>();

            _backToMenu.BackToMenuEvent += () =>
            {
                gameObject.SetActive(false);
                _mainMenu.SetActive(true);
            };

        }
    }
}
