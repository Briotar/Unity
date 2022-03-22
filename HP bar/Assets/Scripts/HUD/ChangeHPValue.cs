using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(ChangeHPView))]

    public class ChangeHPValue : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        private ChangeHPView _increase;

        private float _decreasedValue = -0.1f;
        private float _increasedValue = 0.1f;

        private float _speed = 0.1f;
        private float _targetHP;

        private void Start()
        {
            _increase = GetComponent<ChangeHPView>();
            _targetHP = _slider.normalizedValue;

            _increase.IncreaseEvent += () =>
            {
                _targetHP = _slider.normalizedValue + _increasedValue;
            };

            _increase.DecreaseEvent += () =>
            {
                _targetHP = _slider.normalizedValue + _decreasedValue;
            };
        }

        private void Update()
        {
            _slider.normalizedValue = Mathf.MoveTowards(_slider.normalizedValue, _targetHP, _speed * Time.deltaTime);
        }
    }
}
