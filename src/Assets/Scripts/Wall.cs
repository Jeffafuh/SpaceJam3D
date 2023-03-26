using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed = 5f;
    public GameObject CollisionWall;
    public GameObject Character;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward, speed * Time.deltaTime); 
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject == CollisionWall)
        {
            Character.GetComponent<Health>().addScore();
            Destroy(gameObject);
        }
        else if (col.gameObject.CompareTag("Player"))
        {
            Character.GetComponent<Health>().DoDamage();
        }
    }

    void ProcureDubiousShape()
    {

    }
}
