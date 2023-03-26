using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reportScore : MonoBehaviour
{
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        t.text = "score: " + Health.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
