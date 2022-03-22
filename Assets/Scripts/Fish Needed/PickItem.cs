using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public float speed;

    private Transform targetMedicine;
    private Transform targetFeed;

    public bool isMovingMedicine;
    public bool isMovingFeed;

    void Start()
    {
        isMovingMedicine = false;
        isMovingFeed = false;
    }

    void Update()
    {
        if(isMovingMedicine == true)
        {
            targetMedicine = GameObject.FindGameObjectWithTag("Medicine").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, targetMedicine.position, speed * Time.deltaTime);
        }

        if(isMovingFeed == true)
        {
            targetFeed = GameObject.FindGameObjectWithTag("Feed").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, targetFeed.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Medicine")
        {
            isMovingMedicine = false;
            Destroy(targetMedicine.gameObject);
        }

        if(col.gameObject.tag == "Feed")
        {
            isMovingFeed = false;
            Destroy(targetFeed.gameObject);
        }
    }
}
