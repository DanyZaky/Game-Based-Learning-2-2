using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dayNightScript : MonoBehaviour
{

    GameObject fishPond;
    SpriteRenderer Sprite;
    pondScript pondCs;
    
    [SerializeField] Color dayColor = Color.black;
    [SerializeField] Color nightColor = Color.black;

    [SerializeField] private TextMeshProUGUI phLevelInfo;

    public string dayPhase;
    
    void Start()
    {
        // GameObject dayCycle = GameObject.Find("day cycle");
        // dayNightScript pondCs = dayCycle.GetComponent<dayNightScript>();
        fishPond = GameObject.Find("fishPond");
        pondCs = fishPond.GetComponent<pondScript>();
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dayPhase = pondCs.getDayPhase();
        if (dayPhase == "daylight")
        {
            phLevelInfo.SetText("PH = 8");
            Sprite.color = dayColor;

        }
        
        else if (dayPhase == "night")
        {
            phLevelInfo.SetText("PH = 5");
            Sprite.color =nightColor;
        }
    }

}
