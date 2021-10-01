using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;

    public void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        var spawnEnemyJob = StartCoroutine(SpawnEnemyWithDelay());
    }

    private IEnumerator SpawnEnemyWithDelay()
    {
        var waitForTwoSeconds = new WaitForSecondsRealtime(2f);

        for (int i = 0; i < _points.Length; i++)
        {
            Vector3 currentPosition = new Vector3(_points[i].position.x, _points[i].position.y, _points[i].position.z);
            Instantiate(_enemy, currentPosition, Quaternion.identity);

            yield return waitForTwoSeconds;
        }
    }
}
