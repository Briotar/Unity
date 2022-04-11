using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(HpBarMover))]
    public class HpBar : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private Player _player;

        private HpBarMover _coroutine;

        private float _speed = 1f;
        private float _targetHP;

        private void OnEnable()
        {
            _coroutine = GetComponent<HpBarMover>();

            _player.HealthChanged.AddListener(OnHealthChanged);
        }

        private void OnDisable()
        {
            _player.HealthChanged.RemoveListener(OnHealthChanged);
        }

        private void OnHealthChanged(int value)
        {
            float currentValue = value / 100f;

            _targetHP = _slider.normalizedValue + currentValue;
            _coroutine.StartHpBarMover(_slider, _targetHP, _speed);
        }
    }
}
