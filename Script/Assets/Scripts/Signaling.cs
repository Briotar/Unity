using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signaling : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;
    [SerializeField] private UnityEvent _escaped;
    private AudioSource _myAudioSourse;
    private float _maxVolume = 1f;
    private float _recoveryRate = 0.0005f;

    private void Start()
    {
        _myAudioSourse = GetComponent<AudioSource>();
        _myAudioSourse.volume = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Player>(out Player player))
        {
            _reached?.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _myAudioSourse.volume = Mathf.MoveTowards(_myAudioSourse.volume, _maxVolume, _recoveryRate);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _escaped?.Invoke();
        }
    }

    public void VolumeDecreaseStart()
    {
        var volumeDecreaseJob = StartCoroutine(VolumeDecrease());
    }

    private IEnumerator VolumeDecrease()
    {
        var waitForOneSecond = new WaitForSeconds(0.01f);

        while(_myAudioSourse.volume > 0f)
        {
            _myAudioSourse.volume = Mathf.MoveTowards(_myAudioSourse.volume, 0f, _recoveryRate);

            yield return waitForOneSecond;
        }
    }

}
