using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishStat : MonoBehaviour
{
    //water temperature based on a reaserch, please treat it carefully
    public string fishName = "bawal";
    public int fishAgeInDays = 1;
    public int stressLevel = 0;
    public int maxWaterTemperature = 37;
    public int minWaterTemperature = 9;
    public bool alive = true;
    public int sicknessLevel = 0;
    public int starveLevel = 0;
    public bool breedAble = false;
    public bool isMale = true;
    public float lifeSpan = 10;
    // 1 hour = 1s, 1 day = 24s, 1month = 720s
    public bool isReadyToHarvest = false;
    public float weight = 50f;
    public bool isTimeRunning = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AgeCounter();
        GrowthBehaviour();
    }

    void GrowthBehaviour()
    {
        if (lifeSpan < 105)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void AgeCounter()
    {
        if (isTimeRunning)
        {
            if (lifeSpan > 0)
            {
                lifeSpan -= Time.deltaTime;
                Debug.Log(lifeSpan);
                // Debug.Log(Time.timeScale);
            }
        }
    }

    void IsFishHasDeployed()
    {}
}
