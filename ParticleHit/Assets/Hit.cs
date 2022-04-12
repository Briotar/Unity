using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private bool _isHit;
    [SerializeField] private ParticleHit _particleHit;

    private void Start()
    {
        _isHit = false;
    }

    private void Update()
    {
        if (_isHit)
        {
            _particleHit.gameObject.SetActive(true);
            StartCoroutine(WaitForThreeSec());
        }
    }

    private IEnumerator WaitForThreeSec()
    {
        yield return new WaitForSeconds(3f);

        _isHit = false;
        _particleHit.gameObject.SetActive(false);
    }
}
