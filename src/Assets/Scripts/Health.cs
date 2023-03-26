using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public int health = 10;
    public int dmg_delt = 1;
    public static int score = 0;
    // Start is called before the first frame update
    public Text t; 
    public Text t2;

    void Start()
    {
        t.text = "health: " + health;
        t2.text = "score: " + score;
    }

    public void addScore()
    {
        score = score + 5;
        t2.text = "score: " + score;
    }

    public void DoDamage()
    {
        health = health - dmg_delt;
        t.text = "health: " + health;

        if(health <= 0) {
            if (main.m_skeletalTrackingProvider != null)
            {
                main.m_skeletalTrackingProvider.Dispose();
            }
            SceneManager.LoadScene("Death");
        }
    }
}