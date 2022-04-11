using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HpBar : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private Player _player;
        [SerializeField] private float _speed = 50f;

        private void OnEnable()
        {
            _player.HealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            _player.HealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged(float targetHp)
        {
            StartCoroutine(MovingHPBar(_slider, targetHp, _speed));
        }

        private IEnumerator MovingHPBar(Slider slider, float targetHP, float speed)
        {
            while (slider.value != targetHP)
            {
                slider.value = Mathf.MoveTowards(slider.value, targetHP, speed * Time.deltaTime);

                yield return null;
            }
        }
    }
}
