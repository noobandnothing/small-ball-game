using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball1 : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        float mv_h = Input.GetAxis("Horizontal");
        float mv_v = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(mv_h,0.0f,mv_v);
        Debug.Log(mov);
        rb.AddForce(mov *speed);
    }
}

    public class RotateWithCam : MonoBehaviour
    {
        public GameObject go;
    void LateUpdate()
        {
          //attach Game Object go to target
            Transform target = Camera.main.transform;
            go.transform.parent = target;
        }
    }
 