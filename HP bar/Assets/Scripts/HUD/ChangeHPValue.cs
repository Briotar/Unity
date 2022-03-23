using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(ChangeHPView))]
    [RequireComponent(typeof(HpBarCoroutine))]

    public class ChangeHPValue : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        private ChangeHPView _increase;
        private HpBarCoroutine _coroutine;

        private float _decreasedValue = -0.1f;
        private float _increasedValue = 0.1f;

        private float _speed = 1f;
        private float _targetHP;

        private void Start()
        {
            _increase = GetComponent<ChangeHPView>();
            _coroutine = GetComponent<HpBarCoroutine>();
            _targetHP = _slider.normalizedValue;

            _increase.IncreaseEvent += () =>
            {
                _targetHP = _slider.normalizedValue + _increasedValue;
                _coroutine.StartHpBarCoroutine(_slider, _targetHP, _speed);
            };

            _increase.DecreaseEvent += () =>
            {
                _targetHP = _slider.normalizedValue + _decreasedValue;
                _coroutine.StartHpBarCoroutine(_slider, _targetHP, _speed);
            };
        }
    }
}
