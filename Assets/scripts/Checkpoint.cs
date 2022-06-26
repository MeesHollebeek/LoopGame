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
    [SerializeField] private GameObject Objecten6;
    [SerializeField] private GameObject Objecten7;
    [SerializeField] private GameObject Objecten8;
    [SerializeField] private GameObject WeakObjecten1;
    [SerializeField] private GameObject WeakObjecten2;
    [SerializeField] private GameObject WeakObjecten3;
    [SerializeField] private GameObject WeakObjecten4;
    [SerializeField] private GameObject WeakObjecten5;
    [SerializeField] private GameObject WeakObjecten6;
    [SerializeField] private GameObject WeakObjecten7;
    [SerializeField] private GameObject WeakObjecten8;
    [SerializeField] private GameObject UltraWeakObjecten1;
    [SerializeField] private GameObject UltraWeakObjecten2;
    [SerializeField] private GameObject UltraWeakObjecten3;
    [SerializeField] private GameObject UltraWeakObjecten4;
    [SerializeField] private GameObject UltraWeakObjecten5;
    [SerializeField] private GameObject UltraWeakObjecten6;
    [SerializeField] private GameObject UltraWeakObjecten7;
    [SerializeField] private GameObject UltraWeakObjecten8;
    [SerializeField] private GameObject lamapkapot1;
    [SerializeField] private GameObject geluidlamapkapot1;
    [SerializeField] private GameObject geluidcreepyintroductie;
    [SerializeField] private GameObject buzzing;
    [SerializeField] private GameObject wobbelmusic;
    [SerializeField] private GameObject moon;
    [SerializeField] private GameObject whispers;
    [SerializeField] private GameObject spotlightsfx;
    [SerializeField] private GameObject scream;
    [SerializeField] private GameObject allelampen;
    [SerializeField] private GameObject background;

    [SerializeField] private GameObject kapot1;
    [SerializeField] private GameObject kapot2;
    [SerializeField] private GameObject kapot3;
    [SerializeField] private GameObject kapot4;
    [SerializeField] private GameObject kapot5;
    [SerializeField] private GameObject kapot6;
    [SerializeField] private GameObject kapot7;
    [SerializeField] private GameObject kapot8;
    [SerializeField] private GameObject kapot9;
    [SerializeField] private GameObject kapot10;

    [SerializeField] private GameObject lamp1;
    [SerializeField] private GameObject lamp2;
    [SerializeField] private GameObject lamp3;
    [SerializeField] private GameObject lamp4;
    [SerializeField] private GameObject lamp5;
    [SerializeField] private GameObject lamp6;
    [SerializeField] private GameObject lamp7;
    [SerializeField] private GameObject lamp8;

    [SerializeField] private GameObject FinalBLow;

    [SerializeField] private GameObject Police;
    [SerializeField] private GameObject amublance;

    [SerializeField] private GameObject PoliceLight1;
    [SerializeField] private GameObject PoliceLight2;
    [SerializeField] private GameObject PoliceLight3;
    [SerializeField] private GameObject PoliceLight4;
    [SerializeField] private GameObject PoliceLight5;
    [SerializeField] private GameObject PoliceLight6;
    [SerializeField] private GameObject PoliceLight7;
    [SerializeField] private GameObject PoliceLight8;
    [SerializeField] private GameObject Car;
    [SerializeField] private GameObject bloed;



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
           buzzing.SetActive(true);

        }

        if (loopCount == 3)
        {
            WeakObjecten1.SetActive(true);
            WeakObjecten2.SetActive(true);
            WeakObjecten3.SetActive(true);
            WeakObjecten4.SetActive(true);
            WeakObjecten5.SetActive(true);
            WeakObjecten6.SetActive(true);
            WeakObjecten7.SetActive(true);
            WeakObjecten8.SetActive(true);
            Objecten1.SetActive(false);
            Objecten2.SetActive(false);
            Objecten3.SetActive(false);
            Objecten4.SetActive(false);
            Objecten5.SetActive(false);
            Objecten6.SetActive(false);
            Objecten7.SetActive(false);
            Objecten8.SetActive(false);

            geluidcreepyintroductie.SetActive(true);

        }
        if (loopCount == 4)
        {
           lamapkapot1.SetActive(false);
           geluidlamapkapot1.SetActive(true);
            geluidcreepyintroductie.SetActive(false);
        }
        if (loopCount == 5)
        {
            WeakObjecten1.SetActive(false);
            WeakObjecten2.SetActive(false);
            WeakObjecten3.SetActive(false);
            WeakObjecten4.SetActive(false);
            WeakObjecten5.SetActive(false);
            WeakObjecten6.SetActive(false);
            WeakObjecten7.SetActive(false);
            WeakObjecten8.SetActive(false);
            UltraWeakObjecten1.SetActive(true);
            UltraWeakObjecten2.SetActive(true);
            UltraWeakObjecten3.SetActive(true);
            UltraWeakObjecten4.SetActive(true);
            UltraWeakObjecten5.SetActive(true);
            UltraWeakObjecten6.SetActive(true);
            UltraWeakObjecten7.SetActive(true);
            UltraWeakObjecten8.SetActive(true);

            geluidcreepyintroductie.SetActive(true);

        }
        if (loopCount == 6)
        {
            moon.SetActive(true);
            whispers.SetActive(true);
            spotlightsfx.SetActive(true);
        }
            if (loopCount == 7)
        {
            Objecten2.SetActive(true);
            Objecten1.SetActive(true);
            Objecten3.SetActive(true);
            Objecten4.SetActive(true);
            Objecten5.SetActive(true);
            Objecten6.SetActive(true);
            Objecten7.SetActive(true);
            Objecten8.SetActive(true);
            UltraWeakObjecten2.SetActive(false);
            UltraWeakObjecten3.SetActive(false);
            UltraWeakObjecten4.SetActive(false);
            UltraWeakObjecten5.SetActive(false);
            UltraWeakObjecten1.SetActive(false);
            UltraWeakObjecten6.SetActive(false);
            UltraWeakObjecten7.SetActive(false);
            UltraWeakObjecten8.SetActive(false);

            wobbelmusic.SetActive(true);

            moon.SetActive(false);

            scream.SetActive(true);
        }
        if (loopCount == 8)
        {
            lamp1.SetActive(false);
            lamp2.SetActive(false);
            lamp3.SetActive(false);
            lamp4.SetActive(false);
            lamp5.SetActive(false);
            lamp6.SetActive(false);
            lamp7.SetActive(false);
            lamp8.SetActive(false);
            allelampen.SetActive(false);
            background.SetActive(false);
            scream.SetActive(false);
            wobbelmusic.SetActive(false);
            lamapkapot1.SetActive(false);
            kapot1.SetActive(true);
            kapot2.SetActive(true);
            kapot3.SetActive(true);
            kapot4.SetActive(true);
            kapot5.SetActive(true);
            kapot6.SetActive(true);
            kapot7.SetActive(true);
            kapot8.SetActive(true);
            kapot9.SetActive(true);
            kapot10.SetActive(true);
        }
        if (loopCount == 9)
        {
            FinalBLow.SetActive(true);
            Objecten1.SetActive(false);
            Objecten2.SetActive(false);
            Objecten3.SetActive(false);
            Objecten4.SetActive(false);
            Objecten5.SetActive(false);
            Objecten6.SetActive(false);
            Objecten7.SetActive(false);
            Objecten8.SetActive(false);
            Police.SetActive(true);
            PoliceLight1.SetActive(true);
            PoliceLight2.SetActive(true);
            PoliceLight3.SetActive(true);
            PoliceLight4.SetActive(true);
            PoliceLight5.SetActive(true);
            PoliceLight6.SetActive(true);
            PoliceLight7.SetActive(true);
            PoliceLight8.SetActive(true);

        }
        if (loopCount == 10)
        {
            Objecten2.SetActive(true);
            Objecten1.SetActive(true);
            Objecten3.SetActive(true);
            Objecten4.SetActive(true);
            Objecten5.SetActive(true);
            Objecten6.SetActive(true);
            Objecten7.SetActive(true);
            Objecten8.SetActive(true);
            lamp1.SetActive(true);
            lamp2.SetActive(true);
            lamp3.SetActive(true);
            lamp4.SetActive(true);
            lamp5.SetActive(true);
            lamp6.SetActive(true);
            lamp7.SetActive(true);
        }
    }
}
