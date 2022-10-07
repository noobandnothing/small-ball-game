using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausebutton : MonoBehaviour
{
    public static  int  checker_np = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pause(){
        if(checker_np == 1){
            Time.timeScale = 1f;
            checker_np = 0;
        }else if(checker_np == 0){
            Time.timeScale = 0f;
            checker_np = 1;
        }
        
    }
}
