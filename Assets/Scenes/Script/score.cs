using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int score_value = 0;
    Text score_txt;
    // Start is called before the first frame update
    void Start()
    {
        score_txt = GetComponent<Text> () ;
       
    }

    // Update is called once per frame
    void Update()
    {
         score_txt.text = "Score " + score_value;
    }
}
