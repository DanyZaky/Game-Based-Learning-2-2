using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishNeededManager : MonoBehaviour
{
    [SerializeField] private GameObject medicinePrefabs, feedPrefabs;
    private float randomPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void medicineButton()
    {
        randomPos = Random.Range(-8f, 7f);

        Instantiate(medicinePrefabs, new Vector2(randomPos, 5f), Quaternion.identity);
    }

    public void feedButton()
    {
        randomPos = Random.Range(-8f, 7f);

        Instantiate(feedPrefabs, new Vector2(randomPos, 5f), Quaternion.identity);
    }
}
