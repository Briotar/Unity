using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoneyCollect : MonoBehaviour
{
    [SerializeField] private UnityEvent _collect; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            _collect?.Invoke();
            Destroy(gameObject, 0.2f);
        }
    }
}
