using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_camera : MonoBehaviour
{
    public Camera camera1, camera2;

    // Start is called before the first frame update
    void Start()
    {
        //camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    public void camera()
    {
       
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
      
    }
}
