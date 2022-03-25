using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapCat : MonoBehaviour
{
    private float HPCat, HPCatCounter;
    private CatSpawner cs;
    void Start()
    {
        HPCat = 10f;
        HPCatCounter = HPCat;
        cs = GameObject.Find("Fish Needed Manager").GetComponent<CatSpawner>();
    }

    void Update()
    {
        if(HPCatCounter <= 0)
        {
            Debug.Log("mati");
            Destroy(transform.parent.gameObject);

            cs.isDuration = true;
            cs.isSpawned = true;
        }
    }

    private void OnMouseDown()
    {
        HPCatCounter -= 1f;
        //HPFishFill.fillAmount = HPFishCounter / 10;
        Debug.Log("HP" + HPCatCounter);
    }
}
