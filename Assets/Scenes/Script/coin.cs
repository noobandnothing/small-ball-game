using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotation_speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Coin is here");
    }

    // Update is called once per frame
    void Update ()
    {
     transform.Rotate (Vector3.up * rotation_speed /*Time.deltaTime*/);
    }
   
    void OnCollisionEnter(Collision Gobject)
    {
        if (Gobject.gameObject.tag.Equals("ball"))
        {
            Destroy(gameObject);
            score.score_value++;
        }
    }
}

