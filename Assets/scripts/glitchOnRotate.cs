using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class glitchOnRotate : MonoBehaviour
{
    public Transform playerBody;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       if(playerBody.transform.rotation.y > 0.67 || playerBody.transform.rotation.y < -0.67)
        {
            
        }

       //Debug.Log(playerBody.transform.rotation.y);
    }
}
