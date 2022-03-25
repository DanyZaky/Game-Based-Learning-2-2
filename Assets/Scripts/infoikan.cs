using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoikan : MonoBehaviour
{
    public GameObject openedhandbook;
    public bool aktif;
    public void onmousedown()
    {
        openedhandbook.SetActive(aktif);
    }
}
