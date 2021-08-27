using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;

    public void Start()
    {
        int spawnCount = 3;
        var spawnEnemyJob = StartCoroutine(SpawnEnemyWithDelay(spawnCount));
    }

    private IEnumerator SpawnEnemyWithDelay(int spawnCount)
    {
        var waitForTwoSeconds = new WaitForSecondsRealtime(2f);
        bool isWork = true;

        while(isWork)
        {
            switch(spawnCount)
            {
                case 1:
                    Instantiate(Enemy, new Vector3(-5, 2, 0), Quaternion.identity);
                    spawnCount--;
                    break;

                case 2:
                    Instantiate(Enemy, new Vector3(5, 4, 0), Quaternion.identity);
                    spawnCount--;
                    break;

                case 3:
                    Instantiate(Enemy, new Vector3(2, -1, 0), Quaternion.identity);
                    spawnCount--;
                    break;

                default:
                    isWork = false;
                    break;
            }

            yield return waitForTwoSeconds;
        }
    }
}
