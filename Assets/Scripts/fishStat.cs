using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishStat : MonoBehaviour
{
    //water temperature based on a reaserch, please treat it carefully
    public string fishName = "bawal";
    public int fishAgeInDays = 0;
    public int stressLevel = 0;
    public int maxWaterTemperature = 37;
    public int minWaterTemperature = 9;
    public bool alive = true;
    public int sicknessLevel = 0;
    public int starveLevel = 0;
    public bool breedAble = false;
    public bool isMale = true;
    public float lifeSpan = 150;
    float timePerDay = 24f;
    // 1 hour = 1s, 1 day = 24s, 1month = 720s
    public bool isReadyToHarvest = false;
    public float weight = 50f;
    public bool isTimeRunning = false;
    public int healthPoint = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AgeCounter();
        // Debug.Log(fishAgeInDays);
        GrowthBehaviour();
    }

    void GrowthBehaviour()
    {
        if (fishAgeInDays == 2)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void AgeCounter()
    {
        if (isTimeRunning)
        {
            if (timePerDay > 0)
            {
                timePerDay -= Time.deltaTime;
            }
            else
            {
                fishAgeInDays+=1;
                timePerDay = 24f;
            }
        }
    }

    void IsFishHasDeployed()
    {}
}
