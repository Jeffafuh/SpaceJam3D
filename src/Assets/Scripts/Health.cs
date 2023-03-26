using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 10;
    public int dmg_delt = 1;
    // Start is called before the first frame update
    public Text t; 

    void Start()
    {
        t.text = "health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoDamage()
    {
        health = health - dmg_delt;
        t.text = "health: " + health;

        if(health <= 0) {
            SceneManager.LoadScene("Death");
        }
    }
}