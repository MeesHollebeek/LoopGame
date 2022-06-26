using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontmove : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
        }
        if (Input.GetKeyDown("w"))
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (Input.GetKeyDown("a"))
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (Input.GetKeyDown("d"))
        {
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        else
        {
            
        }
    }
}
