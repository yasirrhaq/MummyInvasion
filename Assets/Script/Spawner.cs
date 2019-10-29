using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnerDelay;
    public int enemyCount;
    public int enemySpawned;
    public GameObject spawnedPrefabs;
    public List<Transform> spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner(spawnerDelay));
    }

    IEnumerator EnemySpawner(float wait)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            int random = Random.Range(0, spawnPos.Count);
            if (spawnPos[random].childCount < 1 && enemySpawned <= enemyCount)
            {
                spawnedPrefabs = Instantiate(spawnedPrefabs, spawnPos[random].position, Quaternion.identity);
                spawnedPrefabs.transform.SetParent(spawnPos[random]);
                spawnedPrefabs.transform.localEulerAngles = new Vector3(0,spawnPos[random].transform.rotation.y,0);       
                enemySpawned++;
                yield return new WaitForSeconds(wait);
            }
            else
            {
                i--;
            }
        }

    }
}
