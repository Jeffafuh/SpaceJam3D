using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMain : MonoBehaviour
{
    public void returnToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
