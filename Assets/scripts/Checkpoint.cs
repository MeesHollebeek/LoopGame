using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject Objecten1;
    [SerializeField] private GameObject Objecten2;
    [SerializeField] private GameObject Objecten3;
    [SerializeField] private GameObject Objecten4;
    [SerializeField] private GameObject Objecten5;
    [SerializeField] private GameObject WeakObjecten1;
    [SerializeField] private GameObject WeakObjecten2;
    [SerializeField] private GameObject WeakObjecten3;
    [SerializeField] private GameObject WeakObjecten4;
    [SerializeField] private GameObject WeakObjecten5;
    [SerializeField] private GameObject UltraWeakObjecten1;
    [SerializeField] private GameObject UltraWeakObjecten2;
    [SerializeField] private GameObject UltraWeakObjecten3;
    [SerializeField] private GameObject UltraWeakObjecten4;
    [SerializeField] private GameObject UltraWeakObjecten5;


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
           

        }

        if (loopCount == 3)
        {
            WeakObjecten1.SetActive(true);
            WeakObjecten2.SetActive(true);
            WeakObjecten3.SetActive(true);
            WeakObjecten4.SetActive(true);
            WeakObjecten5.SetActive(true);
            Objecten1.SetActive(false);
            Objecten2.SetActive(false);
            Objecten3.SetActive(false);
            Objecten4.SetActive(false);
            Objecten5.SetActive(false);

        }
        if (loopCount == 4)
        {
           
        }
        if (loopCount == 5)
        {
            WeakObjecten1.SetActive(false);
            WeakObjecten2.SetActive(false);
            WeakObjecten3.SetActive(false);
            WeakObjecten4.SetActive(false);
            WeakObjecten5.SetActive(false);
            UltraWeakObjecten1.SetActive(true);
            UltraWeakObjecten2.SetActive(true);
            UltraWeakObjecten3.SetActive(true);
            UltraWeakObjecten4.SetActive(true);
            UltraWeakObjecten5.SetActive(true);

        }
        if (loopCount == 7)
        {
            Objecten2.SetActive(true);
            Objecten1.SetActive(true);
            Objecten3.SetActive(true);
            Objecten4.SetActive(true);
            Objecten5.SetActive(true);
            UltraWeakObjecten2.SetActive(false);
            UltraWeakObjecten3.SetActive(false);
            UltraWeakObjecten4.SetActive(false);
            UltraWeakObjecten5.SetActive(false);
            UltraWeakObjecten1.SetActive(false);
        }
    }
}
