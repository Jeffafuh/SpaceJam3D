using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallSpawner : MonoBehaviour
{
    public int wallCount = 5;
    public float wallSpawnTimer = 3;
    private float timer = 0;
    public GameObject[] WallRef;

    private System.Random r;
    // Start is called before the first frame update
    void Start()
    {
        r = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (main.m_skeletalTrackingProvider != null)
            {
                main.m_skeletalTrackingProvider.Dispose();
            }
            SceneManager.LoadScene("MainMenu");
        }

        timer += Time.deltaTime;
        if (timer >= wallSpawnTimer)
        {
            timer = 0;
            for(int i = 0; i < 4; i++){
                int rInt = r.Next(0,6);
                        
                GameObject temp = Instantiate(WallRef[rInt]);
                //temp.GetComponent<Wall>().speed = 50;
                temp.SetActive(true);
            }
            
        }
    }
}
