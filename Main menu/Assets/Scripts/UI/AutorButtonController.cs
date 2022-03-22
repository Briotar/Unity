using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(AutorButtonView))]

    public class AutorButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _autorMenu;
        [SerializeField] private GameObject _mainMenu;

        private AutorButtonView _autor;

        private void Start()
        {
            _autor = GetComponent<AutorButtonView>();

            _autor.AutorEvent += () =>
            {
                _autorMenu.SetActive(true);
                _mainMenu.SetActive(false);
            };
        }
    }
}
