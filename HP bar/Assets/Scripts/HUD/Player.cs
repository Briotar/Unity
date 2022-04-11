using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public UnityEvent<int> HealthChanged;

    public void OnHealthChanged(int value)
    {
        HealthChanged?.Invoke(value);
    }
}
