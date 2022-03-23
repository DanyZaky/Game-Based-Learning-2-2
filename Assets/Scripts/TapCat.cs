using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapCat : MonoBehaviour
{
    private float HPCat, HPCatCounter;
    void Start()
    {
        HPCat = 10f;
        HPCatCounter = HPCat;
    }

    void Update()
    {
        if(HPCatCounter <= 0)
        {
            Debug.Log("mati");
            Destroy(transform.parent.gameObject);
        }
    }

    private void OnMouseDown()
    {
        HPCatCounter -= 1f;
        //HPFishFill.fillAmount = HPFishCounter / 10;
        Debug.Log("HP" + HPCatCounter);
    }
}
