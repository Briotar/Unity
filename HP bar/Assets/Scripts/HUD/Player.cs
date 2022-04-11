using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private float _currentHealth;
    private float _maxSliderValue;
    private float _minSliderValue;

    public UnityEvent<float> HealthChanged;

    private void Start()
    {
        _maxSliderValue = 100;
        _minSliderValue = 0;
        _currentHealth = _maxHealth;

        HealthChanged?.Invoke(_currentHealth);
    }

    public void OnButtonClick(int value)
    {
        if ((_currentHealth + value) < _minSliderValue)
            _currentHealth = _minSliderValue;
        else if ((_currentHealth + value) > _maxSliderValue)
            _currentHealth = _maxSliderValue;
        else
            _currentHealth += value;

        OnHealthChanged();
    }

    private void OnHealthChanged()
    {
        HealthChanged?.Invoke(_currentHealth);
    }
}
