using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision Gobject)
    {
        if (Gobject.gameObject.tag.Equals("ball"))
        {
            Time.timeScale = 0f;
        }
    }
}
