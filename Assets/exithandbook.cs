using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exithandbook : MonoBehaviour
{
    public GameObject openedhandbook;
    public void ClosePanel()
    {
        if(openedhandbook != null)
        {
            openedhandbook.SetActive(false);
        }
    }
}
