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

    public event UnityAction<float> HealthChanged;

    private void Start()
    {
        _maxSliderValue = 100;
        _minSliderValue = 0;
        _currentHealth = _maxHealth;

        HealthChanged?.Invoke(_currentHealth);
    }

    public void OnHealthChanged(int value)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + value, _minSliderValue, _maxSliderValue);

        HealthChanged?.Invoke(_currentHealth);
    }
}
