using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public float speed;

    private Transform targetMedicine;
    private Transform targetFeed;

    private FishNeededManager fnm;

    private void Start()
    {
        fnm = GameObject.Find("Fish Needed Manager").GetComponent<FishNeededManager>();
    }

    void Update()
    {
        if(fnm.isMovingMedicine == true)
        {
            targetMedicine = GameObject.FindGameObjectWithTag("Medicine").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, targetMedicine.position, speed * Time.deltaTime);

            if (targetMedicine.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
            else if (targetMedicine.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }
        }

        if(fnm.isMovingFeed == true)
        {
            targetFeed = GameObject.FindGameObjectWithTag("Feed").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, targetFeed.position, speed * Time.deltaTime);

            if (targetFeed.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
            else if (targetFeed.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 1);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Medicine")
        {
            fnm.isMovingMedicine = false;
            fnm.isPatrolling = true;
            Destroy(targetMedicine.gameObject);
        }

        if(col.gameObject.tag == "Feed")
        {
            fnm.isMovingFeed = false;
            fnm.isPatrolling = true;
            Destroy(targetFeed.gameObject);
        }

        if (col.gameObject.tag == "Cat")
        {
            Debug.Log("PPPPPPPPPP");
            Destroy(gameObject);
            
        }
    }
}
