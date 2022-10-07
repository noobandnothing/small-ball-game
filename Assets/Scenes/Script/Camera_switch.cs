using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_switch : MonoBehaviour
{   
    public Camera camera;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {

    }
    void change_camera() 
    {
      //This will toggle the enabled state of the two cameras between true and false each time
      camera.enabled = !camera.enabled;
      camera2.enabled = !camera2.enabled;
    }
}
