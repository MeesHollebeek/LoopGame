using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject Bank1;
    [SerializeField] private GameObject Bank2;
    [SerializeField] private GameObject Bank3;
    [SerializeField] private GameObject Bank4;
    [SerializeField] private GameObject Bank5;
    [SerializeField] private GameObject Lantaarn1;
    [SerializeField] private GameObject Lantaarn2;
    [SerializeField] private GameObject Lantaarn3;
    [SerializeField] private GameObject Lantaarn4;
    [SerializeField] private GameObject Lantaarn5;
    [SerializeField] private GameObject Vuilnisbak1;
    [SerializeField] private GameObject Vuilnisbak2;
    [SerializeField] private GameObject Vuilnisbak3;
    [SerializeField] private GameObject Vuilnisbak4;
    [SerializeField] private GameObject Vuilnisbak5;
    //private Vector3 scaleChange;


    //scaleChange = new Vector3(10f, 10f, 10f);

    private int loopCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        

       

        Rigidbody R = player.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "loop")
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = true;
            loopCount++;
        }
            if (loopCount == 2)
            {

            Debug.Log("jaa");
            Bank1.SetActive(false);

        }

        if (loopCount == 3)
        {        
            Bank2.SetActive(false);
            Bank5.SetActive(false);
            Bank3.SetActive(false);
            Bank4.SetActive(false);
        }
        if (loopCount == 4)
        {
            Lantaarn1.SetActive(false);
            Lantaarn2.SetActive(false);
            Lantaarn3.SetActive(false);
            Lantaarn4.SetActive(false);
            Lantaarn5.SetActive(false);
            Vuilnisbak1.SetActive(false);
            Vuilnisbak2.SetActive(false);
            Vuilnisbak3.SetActive(false);
            Vuilnisbak4.SetActive(false);
            Vuilnisbak5.SetActive(false);
        }
        if (loopCount == 5)
        {
            Bank1.SetActive(true);
            Bank2.SetActive(true);
            Bank5.SetActive(true);
            Bank3.SetActive(true);
            Bank4.SetActive(true);
            Lantaarn1.SetActive(true);
            Lantaarn2.SetActive(true);
            Lantaarn3.SetActive(true);
            Lantaarn4.SetActive(true);
            Lantaarn5.SetActive(true);
            Vuilnisbak1.SetActive(true);
            Vuilnisbak2.SetActive(true);
            Vuilnisbak3.SetActive(true);
            Vuilnisbak4.SetActive(true);
            Vuilnisbak5.SetActive(true);
            Bank1.transform.localScale = new Vector3(10f, 10f, 10f);
            Bank2.transform.localScale = new Vector3(10f, 10f, 10f);
            Bank3.transform.localScale = new Vector3(10f, 10f, 10f);
            Bank4.transform.localScale = new Vector3(10f, 10f, 10f);
            Bank5.transform.localScale = new Vector3(10f, 10f, 10f);
            Lantaarn1.transform.localScale = new Vector3(10f, 10f, 10f);
            Lantaarn2.transform.localScale = new Vector3(10f, 10f, 10f);
            Lantaarn3.transform.localScale = new Vector3(10f, 10f, 10f);
            Lantaarn4.transform.localScale = new Vector3(10f, 10f, 10f);
            Lantaarn5.transform.localScale = new Vector3(10f, 10f, 10f);

        }
    }
}
