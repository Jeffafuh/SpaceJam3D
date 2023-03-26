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
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.back, speed * Time.deltaTime); 
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == CollisionWall)
        {
            Destroy(gameObject);
        }

        if (col.gameObject == Character)
        {
            Debug.Log("IM FUCKING HIT");
            Character.GetComponent<Health>().DoDamage();
        }
    }

    void ProcureDubiousShape()
    {

    }
}
