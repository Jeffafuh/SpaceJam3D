using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed = 5f;
    public GameObject CollisionWall;
    void Start()
    {
        Debug.Log("New wall created");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, CollisionWall.transform.position, speed * Time.deltaTime); 
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == CollisionWall)
        {
            Destroy(gameObject);
        }
    }

    void ProcureDubiousShape()
    {

    }
}
