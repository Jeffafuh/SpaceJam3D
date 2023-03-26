using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public int wallCount = 5;
    public float wallSpawnTimer = 3;
    private float timer = 0;
    public GameObject WallRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= wallSpawnTimer)
        {
            timer = 0;
            GameObject temp = Instantiate(WallRef);
            temp.SetActive(true);
        }
    }
}
