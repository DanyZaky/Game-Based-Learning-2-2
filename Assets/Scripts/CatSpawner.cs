using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] GameObject catPrefabs;

    private float durationSpawn = 15f, durationSpawnCounter, randomPos;
    public bool isSpawned, isDuration;

    void Start()
    {
        durationSpawnCounter = durationSpawn;
        isSpawned = true;
        isDuration = true;
    }

    void Update()
    {
        if(isDuration == true)
        {
            durationSpawnCounter -= 1f * Time.deltaTime;

            if (isSpawned == true && durationSpawnCounter <= 0)
            {
                randomPos = Random.Range(-8f, 7f);

                Instantiate(catPrefabs, new Vector2(randomPos, 5f), Quaternion.identity);
                isSpawned = false;
                isDuration = false;
                durationSpawnCounter = durationSpawn;
            }
        }     
    }
}
