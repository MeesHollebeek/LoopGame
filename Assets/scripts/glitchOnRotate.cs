using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class glitchOnRotate : MonoBehaviour
{
    public Transform playerBody;
    public GlitchEffect script;
    public static bool isPaused;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBody.transform.rotation.y > 0.67 || playerBody.transform.rotation.y < -0.67)
        {
            script.intensity = 1;
            isPaused = true;
            


        }
       else
        {
            script.intensity = 0;
            isPaused = false;
            
        }

        if (playerBody.transform.rotation.y > 0.75 || playerBody.transform.rotation.y < -0.75)
        {
            script.flipIntensity = 1;
        }
        else
        {
            script.flipIntensity = 0;
        }

        if (playerBody.transform.rotation.y > 0.85 || playerBody.transform.rotation.y < -0.85)
        {
            script.colorIntensity = 1;
        }
        else
        {
            script.colorIntensity = 0;
        }
      
    }
}
