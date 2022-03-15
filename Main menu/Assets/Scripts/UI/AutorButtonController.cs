using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class AutorButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _autorMenu;

        public void OnButton()
        {
            gameObject.SetActive(false);
            _autorMenu.SetActive(true);
        }
    }
}
