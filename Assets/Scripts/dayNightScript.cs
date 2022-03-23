using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightScript : MonoBehaviour
{
    // // Start is called before the first frame update
    //     GameObject fishPond = GameObject.Find("fishPond");
    //     pondScript pondCs = fishPond.GetComponent<pondScript>();
    //     GameObject daySprite = GameObject.Find("day");
    //     GameObject nightSprite = GameObject.Find("night");
    GameObject fishPond;
    // GameObject daySprite = GameObject.Find("day");
    // GameObject nightSprite = GameObject.Find("night");
    SpriteRenderer Sprite;
    pondScript pondCs;

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
            //63C3F1
            Sprite.color = new Color(54, 97, 118, 255);

        }else if (dayPhase == "night"){
            Sprite.color = new Color(99, 195, 241, 255);
            //366176
        }
    }

    string GetPhase()
    {
        // return pondCs.getDayPhase();
        return("asd");
    }
}
