using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handbookopener : MonoBehaviour
{

    public GameObject openedhandbook;
    public void OpenedHandbook()
    {
        if (openedhandbook != null)
        {
            openedhandbook.SetActive(true);
        }
    }
}
